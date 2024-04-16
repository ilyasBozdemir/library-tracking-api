import { useState } from 'react';
import {
  Button,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalFooter,
  ModalBody,
  ModalCloseButton,
  FormControl,
  FormLabel,
  Input,
  Textarea,
} from '@chakra-ui/react';

function EditAuthorModal({ author, isOpen, onClose, onUpdate }) {
  
  const [formData, setFormData] = useState({
    name: author?.name,
    surname: author?.surname,
    birthDate: author?.birthDate,
    country: author?.country,
    biography: author?.biography,
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [name]: value,
    }));
  };

  const handleSubmit = () => {
    onUpdate(formData);
    onClose();
  };

  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <ModalContent>
        <ModalHeader>Düzenle</ModalHeader>
        <ModalCloseButton />
        <ModalBody>
          <form onSubmit={handleSubmit}>
            <FormControl id="name">
              <FormLabel>Ad</FormLabel>
              <Input
                type="text"
                name="name"
                value={formData.name}
                onChange={handleChange}
              />
            </FormControl>
            <FormControl id="surname">
              <FormLabel>Soyad</FormLabel>
              <Input
                type="text"
                name="surname"
                value={formData.surname}
                onChange={handleChange}
              />
            </FormControl>
            <FormControl id="birthDate">
              <FormLabel>Doğum Tarihi</FormLabel>
              <Input
                type="date"
                name="birthDate"
                value={formData.birthDate}
                onChange={handleChange}
              />
            </FormControl>
            <FormControl id="country">
              <FormLabel>Ülke</FormLabel>
              <Input
                type="text"
                name="country"
                value={formData.country}
                onChange={handleChange}
              />
            </FormControl>
            <FormControl id="biography">
              <FormLabel>Biyografi</FormLabel>
              <Textarea
                name="biography"
                value={formData.biography}
                onChange={handleChange}
              />
            </FormControl>
          </form>
        </ModalBody>
        <ModalFooter>
          <Button colorScheme="teal" mr={3} onClick={handleSubmit}>
            Kaydet
          </Button>
          <Button variant="ghost" onClick={onClose}>
            İptal
          </Button>
        </ModalFooter>
      </ModalContent>
    </Modal>
  );
}

export default EditAuthorModal;

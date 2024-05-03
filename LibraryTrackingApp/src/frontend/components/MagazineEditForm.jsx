import { useState } from "react";
import {
  Box,
  Button,
  FormControl,
  FormLabel,
  Input,
  Textarea,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalCloseButton,
  ModalBody,
  ModalFooter,
  Text,
} from "@chakra-ui/react";

const MagazineEditForm = ({ magazine, isOpen, onClose, onSubmit }) => {
  const [name, setName] = useState(magazine ? magazine.name : "");
  const [publicationDate, setPublicationDate] = useState(
    magazine ? magazine.publicationDate : ""
  );
  const [coverImage, setCoverImage] = useState(
    magazine ? magazine.coverImage : ""
  );

  const [coverImageURL, setCoverImageURL] = useState(
    magazine ? magazine.coverImage : ""
  );


  const handleSubmit = () => {
    onSubmit({ name, publicationDate, coverImage });
  };

  const handleImageChange = (e) => {
    const selectedFile = e.target.files[0];
    if (selectedFile) {
      setFile(selectedFile);
      setError("");
      setCoverImageURL(URL.createObjectURL(selectedFile)); 
     
      setMagazine((prevMagazine) => ({
        ...prevMagazine,
        coverImage: URL.createObjectURL(selectedFile),
      }));
    } else {
      setFile(null);
      setError("Lütfen bir dosya seçin.");
      setCoverImageURL(""); 
      
      setMagazine((prevMagazine) => ({
        ...prevMagazine,
        coverImage: "",
      }));
    }
  };
  

  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <ModalContent>
        <ModalHeader>Dergi Düzenle</ModalHeader>
        <ModalCloseButton />
        <ModalBody>
          <FormControl>
            <FormLabel htmlFor="name">Dergi Adı</FormLabel>
            <Input
              type="text"
              id="name"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
          </FormControl>
          <FormControl mt={4}>
            <FormLabel htmlFor="publicationDate">Yayın Tarihi</FormLabel>
            <Input
              type="text"
              id="publicationDate"
              value={publicationDate}
              onChange={(e) => setPublicationDate(e.target.value)}
            />
          </FormControl>
          <FormControl mt={4}>
            <FormLabel htmlFor="coverImage">Kapak Resmi</FormLabel>
            <Input
              type="file"
              id="coverImage"
              accept="image/*"
              onChange={handleImageChange}
            />
            <Text mt={2} fontSize="sm" color="gray.500">
              Veya kapak resmi URL'sini girin:
            </Text>
            <Input
              type="text"
              id="coverImageURL"
              value={coverImageURL}
              onChange={(e) => setCoverImageURL(e.target.value)}
            />
            {coverImage && (
              <img
                src={coverImage}
                alt="Kapak Resmi"
                style={{ marginTop: "10px", maxWidth: "100%" }}
              />
            )}
          </FormControl>
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
};

export default MagazineEditForm;

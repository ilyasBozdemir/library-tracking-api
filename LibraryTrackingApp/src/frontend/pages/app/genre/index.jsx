import { useState } from 'react';
import { Box, Button, Heading, Divider, useToast, Text, VStack, Table, Thead, Tbody, Tr, Th, Td, Modal, ModalOverlay, ModalContent, ModalHeader, ModalCloseButton, ModalBody, ModalFooter, FormControl, FormLabel, Switch, Input, Flex } from '@chakra-ui/react';
import { MdAdd, MdDeleteForever, MdEditSquare } from 'react-icons/md';

const initialGenres = [
  { id: 1, name: 'Roman', isActive: true },
  { id: 2, name: 'Bilim Kurgu', isActive: true },
  { id: 3, name: 'Korku', isActive: false },
];

const GenreAddForm = ({ isOpen, onClose, onSubmit }) => {
  const [name, setName] = useState('');
  const [isActive, setIsActive] = useState(true);

  const handleSubmit = () => {
    onSubmit({ name, isActive });
    setName('');
    setIsActive(true);
    onClose();
  };

  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <ModalContent>
        <ModalHeader>Yeni Tür Ekle</ModalHeader>
        <ModalCloseButton />
        <ModalBody>
          <FormControl>
            <FormLabel htmlFor="name">Ad</FormLabel>
            <Input
              type="text"
              id="name"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
          </FormControl>
          <FormControl mt={4} display="flex" alignItems="center">
            <FormLabel htmlFor="isActive" mb={0}>Aktif</FormLabel>
            <Switch id="isActive" colorScheme="blue" isChecked={isActive} onChange={(e) => setIsActive(e.target.checked)} />
          </FormControl>
        </ModalBody>
        <ModalFooter>
          <Button colorScheme="blue" mr={3} onClick={handleSubmit}>Ekle</Button>
          <Button variant="ghost" onClick={onClose}>İptal</Button>
        </ModalFooter>
      </ModalContent>
    </Modal>
  );
};

const GenreEditForm = ({ genre, isOpen, onClose, onSubmit }) => {
  const [name, setName] = useState(genre ? genre.name : '');
  const [isActive, setIsActive] = useState(genre ? genre.isActive : true);

  const handleSubmit = () => {
    onSubmit({ id: genre.id, name, isActive });
    onClose();
  };

  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <ModalContent>
        <ModalHeader>Türü Düzenle</ModalHeader>
        <ModalCloseButton />
        <ModalBody>
          <FormControl>
            <FormLabel htmlFor="name">Ad</FormLabel>
            <Input
              type="text"
              id="name"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
          </FormControl>
          <FormControl mt={4} display="flex" alignItems="center">
            <FormLabel htmlFor="isActive" mb={0}>Aktif</FormLabel>
            <Switch id="isActive" colorScheme="blue" isChecked={isActive} onChange={(e) => setIsActive(e.target.checked)} />
          </FormControl>
        </ModalBody>
        <ModalFooter>
          <Button colorScheme="blue" mr={3} onClick={handleSubmit}>Kaydet</Button>
          <Button variant="ghost" onClick={onClose}>İptal</Button>
        </ModalFooter>
      </ModalContent>
    </Modal>
  );
};

const GenreList = ({ genres, onEdit, onDelete }) => {
  return (
    <Table  variant="striped" >
      <Thead>
        <Tr>
          <Th>Ad</Th>
          <Th>Durum</Th>
          <Th>İşlemler</Th>
        </Tr>
      </Thead>
      <Tbody>
        {genres.map((genre) => (
          <Tr key={genre.id}>
            <Td>{genre.name}</Td>
            <Td>{genre.isActive ? 'Aktif' : 'Pasif'}</Td>
            <Td>
              <Flex gap={3}>
              <Button colorScheme="blue" size="sm" variant={'outline'} leftIcon={<MdEditSquare />}  onClick={() => onEdit(genre)}>Düzenle</Button>
              <Button colorScheme="red" size="sm"  variant={'outline'} leftIcon={<MdDeleteForever />} onClick={() => onDelete(genre.id)}>Sil</Button>
              </Flex>
            </Td>
          </Tr>
        ))}
      </Tbody>
    </Table>
  );
};

const GenrePage = () => {
  const [genres, setGenres] = useState(initialGenres);
  const [selectedGenre, setSelectedGenre] = useState(null);
  const [isEditModalOpen, setIsEditModalOpen] = useState(false);
  const [isAddModalOpen, setIsAddModalOpen] = useState(false);
  const toast = useToast();

  const handleEditGenre = (genre) => {
    setSelectedGenre(genre);
    setIsEditModalOpen(true);
  };

  const handleDeleteGenre = (genreId) => {
    setGenres(genres.filter(genre => genre.id !== genreId));
    toast({
      title: "Tür başarıyla silindi.",
      status: "success",
      duration: 3000,
      isClosable: true,
    });
  };

  const handleUpdateGenre = ({ id, name, isActive }) => {
    setGenres(genres.map(genre => (genre.id === id ? { ...genre, name, isActive } : genre)));
    setSelectedGenre(null);
    setIsEditModalOpen(false);
    toast({
      title: "Tür başarıyla güncellendi.",
      status: "success",
      duration: 3000,
      isClosable: true,
    });
  };

  const handleAddGenre = ({ name, isActive }) => {
    const newGenre = { id: Date.now(), name, isActive };
    setGenres([...genres, newGenre]);
    setIsAddModalOpen(false);
    toast({
      title: "Yeni tür başarıyla eklendi.",
      status: "success",
      duration: 3000,
      isClosable: true,
    });
  };

  return (
    <Box>
      <Button colorScheme="blue" leftIcon={<MdAdd />} onClick={() => setIsAddModalOpen(true)}>Yeni Tür Ekle</Button>
      <Divider my={4} />
      <GenreList genres={genres} onEdit={handleEditGenre} onDelete={handleDeleteGenre} />
      <GenreEditForm genre={selectedGenre} isOpen={isEditModalOpen} onClose={() => setIsEditModalOpen(false)} onSubmit={handleUpdateGenre} />
      <GenreAddForm isOpen={isAddModalOpen} onClose={() => setIsAddModalOpen(false)} onSubmit={handleAddGenre} />
    </Box>
  );
};

export default GenrePage;

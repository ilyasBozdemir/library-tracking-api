import React, { useState } from "react";
import {
  Flex,
  Heading,
  Button,
  Table,
  Thead,
  Tbody,
  Tr,
  Th,
  Td,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalCloseButton,
  ModalBody,
  ModalFooter,
  FormControl,
  FormLabel,
  Input,
  Textarea,
} from "@chakra-ui/react";
import { MdAdd } from "react-icons/md";

const PrintedBooksPage = () => {
  const [books, setBooks] = useState([
    {
      id: 1,
      title: "Harry Potter and the Philosopher's Stone",
      author: "J.K. Rowling",
      publisher: "Bloomsbury",
      publishedDate: "1997-06-26",
    },
    {
      id: 2,
      title: "To Kill a Mockingbird",
      author: "Harper Lee",
      publisher: "J.B. Lippincott & Co.",
      publishedDate: "1960-07-11",
    },
    // Diğer kitaplar...
  ]);

  const [isOpen, setIsOpen] = useState(false);
  const [formData, setFormData] = useState({
    id: "",
    title: "",
    author: "",
    publisher: "",
    publishedDate: "",
  });

  const handleEditClick = (book) => {
    setIsOpen(true);
    setFormData(book);
  };

  const handleCloseModal = () => {
    setIsOpen(false);
    setFormData({
      id: "",
      title: "",
      author: "",
      publisher: "",
      publishedDate: "",
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    // Form verilerini işleme veya güncelleme işlemi burada yapılacak
    // Örneğin: setBooks ile kitap listesini güncelleme
    setIsOpen(false);
    setFormData({
      id: "",
      title: "",
      author: "",
      publisher: "",
      publishedDate: "",
    });
  };

  return (
    <Flex direction="column" p={4}>
      <Button
        onClick={() => setIsOpen(true)}
        leftIcon={<MdAdd />}
        colorScheme="blue"
        mb={4}
      >
        Yeni Kitap Ekle
      </Button>
      <Table variant="striped" colorScheme="blue">
        <Thead>
          <Tr>
            <Th>Sıra</Th>
            <Th>Kitap Adı</Th>
            <Th>Yazar</Th>
            <Th>Yayınevi</Th>
            <Th>Yayın Tarihi</Th>
            <Th>İşlemler</Th>
          </Tr>
        </Thead>
        <Tbody>
          {books.map((book, index) => (
            <Tr key={book.id}>
              <Td>{index + 1}</Td>
              <Td>{book.title}</Td>
              <Td>{book.author}</Td>
              <Td>{book.publisher}</Td>
              <Td>{book.publishedDate}</Td>
              <Td>
                <Button colorScheme="teal" size="sm" onClick={() => handleEditClick(book)}>
                  Düzenle
                </Button>
                {/* Silme butonu ekleme */}
              </Td>
            </Tr>
          ))}
        </Tbody>
      </Table>

      <Modal isOpen={isOpen} onClose={handleCloseModal}>
        <ModalOverlay />
        <ModalContent>
          <ModalHeader>Kitap Düzenle</ModalHeader>
          <ModalCloseButton />
          <ModalBody>
            <form onSubmit={handleSubmit}>
              <FormControl id="title">
                <FormLabel>Kitap Adı</FormLabel>
                <Input
                  type="text"
                  value={formData.title}
                  onChange={(e) => setFormData({ ...formData, title: e.target.value })}
                />
              </FormControl>
              {/* Diğer form alanları eklenebilir */}
            </form>
          </ModalBody>
          <ModalFooter>
            <Button colorScheme="teal" mr={3} onClick={handleSubmit}>
              Kaydet
            </Button>
            <Button variant="ghost" onClick={handleCloseModal}>
              İptal
            </Button>
          </ModalFooter>
        </ModalContent>
      </Modal>
    </Flex>
  );
};

export default PrintedBooksPage;

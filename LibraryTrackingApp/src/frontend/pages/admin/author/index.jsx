import React, { useEffect, useState } from "react";
import {
  Flex,
  Heading,
  Button,
  TableContainer,
  Table,
  Thead,
  Tbody,
  TableCaption,
  Tr,
  Th,
  Td,
  ButtonGroup,
} from "@chakra-ui/react";

import {
  AlertDialog,
  AlertDialogBody,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogContent,
  AlertDialogOverlay,
  AlertDialogCloseButton,
} from "@chakra-ui/react";

import { MdAdd, MdDeleteOutline } from "react-icons/md";
import { useRouter } from "next/router";
import EditAuthorModal from "@/components/Author/EditAuthorModal";
import { FaEdit, FaEye } from "react-icons/fa";
import AuthorService from "@/services/authorService";

const AuthorsPage = () => {
  const router = useRouter();
  const [authors, setAuthors] = useState([]);
  const [authorId, setAuthorId] = useState(null);
  const [selectedAuthor, setSelectedAuthor] = useState(null);
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [isOpen, setIsOpen] = useState(false);
  useEffect(() => {
    const fetchData = async () => {
      try {
        const fetchedAuthor = await AuthorService.getAuthors();
        setAuthors(fetchedAuthor.data);
      } catch (error) {
        console.error("Yazarları getirirken bir hata oluştu:", error);
      }
    };

    fetchData();
  }, []);

  const handleDelete = async (id) => {
    try {
      await AuthorService.deleteAuthorById(id);
      setAuthors(authors.filter((author) => author.id !== id));
      setIsOpen(false);
    } catch (error) {
      console.error("Yazarı silerken bir hata oluştu:", error);
    }
  };

  const cancelRef = React.useRef();

  const handleAddAuthor = () => {
    router.push("/admin/author/new");
  };

  const handleEditClick = (author) => {
    setSelectedAuthor(author);
    setIsModalOpen(true);
  };

  const handleModalClose = () => {
    setIsModalOpen(false);
  };

  const handleUpdateAuthor = async (updatedData) => {
    await AuthorService.updateAuthorById(selectedAuthor.id, updatedData);
    const fetchedAuthor = await AuthorService.getAuthors();
    setAuthors(fetchedAuthor.data);
  };

  const handleDeleteAlertDialog = (id) => {
    setAuthorId(id);
    setIsOpen(true);
  };

  return (
    <Flex direction="column" p={4}>
      <Heading mb={4}>Yazarlar</Heading>

      <Button
        onClick={handleAddAuthor}
        leftIcon={<MdAdd />}
        colorScheme="blue"
        mb={4}
      >
        Yeni Yazar Ekle
      </Button>

      <TableContainer>
        <Table variant="striped" colorScheme="blue">
          <TableCaption>{`${authors?.length} yazar bulundu.`}</TableCaption>
          <Thead>
            <Tr>
              <Th>Sıra</Th>
              <Th>Ad Soyad</Th>
              <Th>Ülke</Th>
              <Th>İşlemler</Th>
            </Tr>
          </Thead>
          <Tbody>
            {authors?.map((author, index) => (
              <Tr key={author.id} _hover={{ backgroundColor: "gray.100" }}>
                <Td>{index + 1}</Td>
                <Td> {`${author.name} ${author.surname}`} </Td>
                <Td> {author.country} </Td>
                <Td>
                  <Button
                    onClick={() => router.push(`/admin/author/${author.id}`)}
                    colorScheme="gray"
                    size="sm"
                    mr={2}
                    leftIcon={<FaEye />}
                  >
                    Görüntüle
                  </Button>
                  <Button
                    onClick={() => handleEditClick(author)}
                    colorScheme="teal"
                    size="sm"
                    mr={2}
                    leftIcon={<FaEdit />}
                  >
                    Düzenle
                  </Button>
                  <Button
                    colorScheme="red"
                    leftIcon={<MdDeleteOutline />}
                    size="sm"
                    onClick={() => handleDeleteAlertDialog(author.id)}
                  >
                    Sil
                  </Button>
                </Td>
              </Tr>
            ))}
          </Tbody>
        </Table>
      </TableContainer>

      <AlertDialog
        isOpen={isOpen}
        leastDestructiveRef={cancelRef}
        onClose={() => setIsOpen(false)}
      >
        <AlertDialogOverlay>
          <AlertDialogContent>
            <AlertDialogHeader fontSize="lg" fontWeight="bold">
              Yazar Silinsin Mi?
            </AlertDialogHeader>

            <AlertDialogBody>
              Emin misin? Bu işlemi daha sonra geri alamazsınız.
            </AlertDialogBody>

            <AlertDialogFooter>
              <ButtonGroup>
                <Button
                  colorScheme="red"
                  onClick={() => handleDelete(authorId)}
                  ml={3}
                >
                  Sil
                </Button>
                <Button ref={cancelRef} onClick={() => setIsOpen(false)}>
                  İptal
                </Button>
              </ButtonGroup>
            </AlertDialogFooter>
          </AlertDialogContent>
        </AlertDialogOverlay>
      </AlertDialog>

      <EditAuthorModal
        author={selectedAuthor}
        isOpen={isModalOpen}
        onClose={handleModalClose}
        onUpdate={handleUpdateAuthor}
      />
    </Flex>
  );
};

export default AuthorsPage;

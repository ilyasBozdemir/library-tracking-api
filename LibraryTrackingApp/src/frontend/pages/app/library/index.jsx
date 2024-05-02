import React, { useEffect } from "react";
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
} from "@chakra-ui/react";
import { libraryModel } from "@/models/library";
import { useRouter } from "next/router";
import { useState } from "react";
import LibraryService from "@/services/libraryService";
import { FaEdit, FaEye } from "react-icons/fa";
import { MdDeleteOutline } from "react-icons/md";
import EditLibraryModal from "@/components/Library/EditLibraryModal";

import {
  AlertDialog,
  AlertDialogBody,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogContent,
  AlertDialogOverlay,
  AlertDialogCloseButton,
} from "@chakra-ui/react";

function LibraryIndexPage() {
  const router = useRouter();
  const cancelRef = React.useRef();

  const [libraries, setLibraries] = useState([]);
  const [selectedLibrary, setSelectedLibrary] = useState(null);
  const [libraryId, setLibraryId] = useState(null);
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [isOpen, setIsOpen] = useState(false);
  useEffect(() => {
    const fetchData = async () => {
      try {
        const fetchedLibrary = await LibraryService.getLibraries();
        setLibraries(fetchedLibrary.data);
      } catch (error) {
        console.error("Kütüphane şubelerini getirirken bir hata oluştu:", error);
      }
    };

    fetchData();
  }, []);

  const handleEditClick = (library) => {
    setSelectedLibrary(library);
    setIsModalOpen(true);
  };

  const handleModalClose = () => {
    setIsModalOpen(false);
  };

  const handleDeleteAlertDialog = (id) => {
    setIsOpen(true);
    setLibraryId(id);
  };

  const handleUpdateLibrary = async (libraryData) => {
    await LibraryService.updateLibraryById(selectedLibrary.id, updatedData);
    const fetchedLibrary = await LibraryService.getLibraries();
    setLibraries(fetchedLibrary.data);
  };

  const handleDelete = async (id) => {
    try {
      await LibraryService.deleteLibraryById(id);
      selectedLibrary(libraries.filter((library) => library.id !== id));
      setIsOpen(false);
    } catch (error) {
      console.error("Şubeyi silerken bir hata oluştu:", error);
    }
  };

  return (
    <>
      <TableContainer>
        <Table variant="striped" colorScheme="blue">
          <TableCaption>{`${libraries.length} kütüphane şubesi bulundu.`}</TableCaption>
          <Thead>
            <Tr>
              <Th>Id</Th>
              <Th>Ad</Th>
              <Th>Adres</Th>
              <Th>Telefon Numarası</Th>
              <Th>İşlemler</Th>
            </Tr>
          </Thead>
          <Tbody>
            {libraries.map((library, index) => (
              <Tr
                key={library.id}
                _hover={{ backgroundColor: "gray.100", cursor: "pointer" }}
              >
                <Td>{index + 1}</Td>
                <Td> {library.name} </Td>
                <Td> {library.address} </Td>
                <Td> {library.phoneNumber} </Td>
                <Td>
                  <Button
                    onClick={() => router.push(`/app/library/${library.id}`)}
                    colorScheme="gray"
                    size="sm"
                    mr={2}
                    leftIcon={<FaEye />}
                  >
                    Görüntüle
                  </Button>
                  <Button
                    onClick={() => handleEditClick(library)}
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
                    onClick={() => handleDeleteAlertDialog(library.id)}
                  >
                    Sil
                  </Button>
                </Td>
              </Tr>
            ))}
          </Tbody>
        </Table>
      </TableContainer>

      <EditLibraryModal
        library={selectedLibrary}
        isOpen={isModalOpen}
        onClose={handleModalClose}
        onUpdate={handleUpdateLibrary}
      />

      <AlertDialog
        isOpen={isOpen}
        leastDestructiveRef={cancelRef}
        onClose={() => setIsOpen(false)}
      >
        <AlertDialogOverlay>
          <AlertDialogContent>
            <AlertDialogHeader fontSize="lg" fontWeight="bold">
              Şube Silinsin Mi?
            </AlertDialogHeader>

            <AlertDialogBody>
              Emin misin? Bu işlemi daha sonra geri alamazsınız.
            </AlertDialogBody>

            <AlertDialogFooter>
              <Button ref={cancelRef} onClick={() => setIsOpen(false)}>
                İptal
              </Button>
              <Button
                colorScheme="red"
                onClick={() => handleDelete(libraryId)}
                ml={3}
              >
                Sil
              </Button>
            </AlertDialogFooter>
          </AlertDialogContent>
        </AlertDialogOverlay>
      </AlertDialog>
    </>
  );
}

export default LibraryIndexPage;

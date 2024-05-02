import { useState } from "react";
import {
  Container,
  Table,
  Thead,
  Tbody,
  Tr,
  Th,
  Td,
  Button,
  useToast,
} from "@chakra-ui/react";

const BorrowListPage = () => {
  const toast = useToast();

  const [borrowedItems, setBorrowedItems] = useState([
    {
      id: 1,
      itemName: "Kitap 1",
      borrowerName: "Ahmet Yılmaz",
      borrowerEmail: "ahmet@example.com",
    },
    {
      id: 2,
      itemName: "Kitap 2",
      borrowerName: "Ayşe Kaya",
      borrowerEmail: "ayse@example.com",
    },
    {
      id: 3,
      itemName: "Kitap 3",
      borrowerName: "Mehmet Demir",
      borrowerEmail: "mehmet@example.com",
    },
  ]);

  const handleReturn = (id) => {
    setBorrowedItems((prevItems) => prevItems.filter((item) => item.id !== id));
    toast({
      title: "Öğe geri alındı",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  return (
    <Container maxW="5xl">
      <Table variant="striped" colorScheme="teal">
        <Thead>
          <Tr>
            <Th>ID</Th>
            <Th>Öğe Adı</Th>
            <Th>Ödünç Alan Kişinin Adı</Th>
            <Th>Ödünç Alan Kişinin E-posta Adresi</Th>
            <Th>İşlemler</Th>
          </Tr>
        </Thead>
        <Tbody>
          {borrowedItems.map((item) => (
            <Tr key={item.id}>
              <Td>{item.id}</Td>
              <Td>{item.itemName}</Td>
              <Td>{item.borrowerName}</Td>
              <Td>{item.borrowerEmail}</Td>
              <Td>
                <Button colorScheme="red" onClick={() => handleReturn(item.id)}>
                  Geri Al
                </Button>
              </Td>
            </Tr>
          ))}
        </Tbody>
      </Table>
    </Container>
  );
};

export default BorrowListPage;

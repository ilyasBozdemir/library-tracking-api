import { useState } from "react";
import {
  Box,
  Button,
  Table,
  Thead,
  Tbody,
  Tr,
  Th,
  Td,
  TableCaption,
} from "@chakra-ui/react";
import UploadForm from "@/components/UploadForm";

const EBooks = () => {
  const [eBooks, setEBooks] = useState([]);

  const handleUpload = (file) => {
    const newEBook = {
      id: Date.now(),
      name: file.name,
      type: file.type,
      size: file.size,
    };
    setEBooks([...eBooks, newEBook]);
  };

  const handleDelete = (id) => {
    setEBooks(eBooks.filter((eBook) => eBook.id !== id));
  };

  return (
    <Box p={4}>
      <UploadForm
        onUpload={handleUpload}
        accept={".pdf, .epub, .mobi"}
        labelName={"E-Kitap Dosyasını buraya bırakınız."}
      />

      <Table variant="striped" colorScheme="blue" mt={8}>
        <TableCaption>{`${eBooks.length} e-kitap bulundu.`}</TableCaption>
        <Thead>
          <Tr>
            <Th>Ad</Th>
            <Th>Dosya Tipi</Th>
            <Th>Boyut (KB)</Th>
            <Th>İşlemler</Th>
          </Tr>
        </Thead>
        <Tbody>
          {eBooks.map((eBook) => (
            <Tr key={eBook.id}>
              <Td>{eBook.name}</Td>
              <Td>{eBook.type}</Td>
              <Td>{(eBook.size / 1024).toFixed(2)}</Td>
              <Td>
                <Button
                  colorScheme="teal"
                  size="sm"
                  mr={2}
                  onClick={() => window.open(`/app/e-books/${eBook.id}`)}
                >
                  Görüntüle
                </Button>
                <Button
                  colorScheme="red"
                  size="sm"
                  onClick={() => handleDelete(eBook.id)}
                >
                  Sil
                </Button>
              </Td>
            </Tr>
          ))}
        </Tbody>
      </Table>
    </Box>
  );
};

export default EBooks;

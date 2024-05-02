import { useState } from "react";
import {
  Button,
  Container,
  FormControl,
  FormLabel,
  Input,
  Stack,
  Text,
  useToast,
} from "@chakra-ui/react";

const BorrowReturnPage = () => {
  const toast = useToast();

  const [formData, setFormData] = useState({
    itemName: "",
    borrowerName: "",
    borrowerEmail: "",
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [name]: value,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(formData);
    toast({
      title: "Bilgiler gönderildi",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  return (
    <Container maxW="md">
      <Stack spacing={4} mt={8}>
        <Text fontSize="xl" fontWeight="bold">Öğe Geri Alma</Text>
        <form onSubmit={handleSubmit}>
          <FormControl id="itemName">
            <FormLabel>Öğe Adı</FormLabel>
            <Input
              type="text"
              name="itemName"
              value={formData.itemName}
              onChange={handleChange}
            />
          </FormControl>
          <FormControl id="borrowerName">
            <FormLabel>Ödünç Alan Kişinin Adı</FormLabel>
            <Input
              type="text"
              name="borrowerName"
              value={formData.borrowerName}
              onChange={handleChange}
            />
          </FormControl>
          <FormControl id="borrowerEmail">
            <FormLabel>Ödünç Alan Kişinin E-posta Adresi</FormLabel>
            <Input
              type="email"
              name="borrowerEmail"
              value={formData.borrowerEmail}
              onChange={handleChange}
            />
          </FormControl>
          <Button type="submit" mt={5} colorScheme="teal">
            Gönder
          </Button>
        </form>
      </Stack>
    </Container>
  );
};

export default BorrowReturnPage;

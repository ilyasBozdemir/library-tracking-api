import { useState } from "react";
import {
  Box,
  Heading,
  VStack,
  Text,
  Input,
  Button,
  Divider,
} from "@chakra-ui/react";

const SupportPage = () => {
  const [title, setTitle] = useState("");
  const [message, setMessage] = useState("");
  const [supportRequests, setSupportRequests] = useState([
    {
      id: 1,
      title: "Kütüphane Açılış Saati Değişikliği",
      message:
        "Kütüphane açılış saati hafta içi saat 10:00'dan 08:00'e alındı. Bu değişiklik hakkında bilgi almak istiyorum.",
      status: "Açık",
    },
    {
      id: 2,
      title: "Kitap İade Süresi Uzatma",
      message: "Kitap iade süresini uzatmak istiyorum. Acaba mümkün mü?",
      status: "Açık",
    },
  ]);

  const handleSubmit = () => {
    console.log("Destek talebi gönderildi:", { title, message });
    if (title && message) {
      setSupportRequests([
        ...supportRequests,
        { id: Date.now(), title, message },
      ]);
      setTitle("");
      setMessage("");
    }
  };

  return (
    <Box p="5">
      <Heading mb="4" >Destek Talebi Oluştur</Heading>
      <VStack spacing="4" align="start">
        <Input
          placeholder="Başlık"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
        />
        <Input
          placeholder="Mesaj"
          value={message}
          onChange={(e) => setMessage(e.target.value)}
        />
        <Button colorScheme="teal" onClick={handleSubmit}>
          Gönder
        </Button>
      </VStack>

      <Divider my="6" />

      <Heading mb="4">Önceki Talepler</Heading>
      <VStack spacing="4" align="start">
        {supportRequests.map((request) => (
          <Box
            key={request.id}
            w="100%"
            border="1px solid"
            borderColor="gray.200"
            borderRadius="md"
            p="4"
          >
            <Text fontWeight="bold">{request.title}</Text>
            <Text color="gray.600">{request.message}</Text>
          </Box>
        ))}
      </VStack>
    </Box>
  );
};

export default SupportPage;

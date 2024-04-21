import { Box, Heading, VStack, Text, Button } from "@chakra-ui/react";
import { FiMessageSquare } from "react-icons/fi";

const SupportPage = () => {
  const supportRequests = [
    {
      id: 1,
      title: "Kütüphane Açılış Saati Değişikliği",
      message: "Kütüphane açılış saati hafta içi saat 10:00'dan 08:00'e alındı. Bu değişiklik hakkında bilgi almak istiyorum.",
      status: "Açık",
    },
    {
      id: 2,
      title: "Kitap İade Süresi Uzatma",
      message: "Kitap iade süresini uzatmak istiyorum. Acaba mümkün mü?",
      status: "Açık",
    },
  ];

  return (
    <Box p="6">
      <Heading mb="4">Destek Talepleri</Heading>
      <VStack spacing="4" align="start">
        {supportRequests.map((request) => (
          <Box key={request.id} w="100%" border="1px solid" borderColor="gray.200" borderRadius="md" p="4">
            <Text fontWeight="bold">{request.title}</Text>
            <Text color="gray.600">{request.message}</Text>
            <Text mt="2" color={request.status === "Açık" ? "red.500" : "green.500"}>{request.status}</Text>
            <Button leftIcon={<FiMessageSquare />} colorScheme="teal" size="sm" mt="2">Yanıtla</Button>
          </Box>
        ))}
      </VStack>
    </Box>
  );
};

export default SupportPage;

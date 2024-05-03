import React from "react";
import { useRouter } from "next/router";
import { Flex, Heading, Text } from "@chakra-ui/react";

const BookDetailPage = () => {
  const router = useRouter();
  const { id } = router.query; // URL'den alınan dinamik parametre değeri

  // Dinamik olarak alınan kitap ID'sine göre ilgili kitabın verilerini getirme (örneğin, API çağrısı veya veritabanı sorgusu)

  return (
    <Flex direction="column" p={4}>
      <Heading mb={4}>Kitap Detayı</Heading>
      <Text>ID: {id}</Text>
    </Flex>
  );
};

export default BookDetailPage;

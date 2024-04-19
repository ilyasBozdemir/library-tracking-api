import React from "react";
import { Flex, Box, Button, Heading, Text, VStack } from "@chakra-ui/react";
import Link from "next/link";
import { NextSeo } from "next-seo";

function IndexPage() {
  return (
    <>
      <NextSeo
        title="Kütüphane Uygulaması"
        description="Kütüphane kitap takip, emanet ve stok bilgilerini yönetmek için kullanışlı bir uygulama. Favori kitaplarınızı ve okuma listelerinizi oluşturabilirsiniz."
      />
      <LandingPage />
    </>
  );
}

const LandingPage = () => {
  return (
    <Flex
      minH="100vh"
      align="center"
      justify="center"
      direction="column"
      bgGradient="linear(to-b, teal.300, teal.800)"
      color="white"
      px={8}
    >
      <Heading as="h1" size="2xl" mb={6} textAlign="center">
        Hoş Geldiniz!
      </Heading>
      <Text fontSize="xl" textAlign="center" mb={8}>
        Kütüphane kitap takip, emanet ve stok bilgilerini yönetmek için
        kullanışlı bir uygulama.
      </Text>

      <Box my={5} textAlign="center">
        <Text fontSize="lg" fontWeight="bold" mb={2}>
          Uygulama Özellikleri:
        </Text>
        <Text fontSize="md" mb={2}>
          - Kitap takibi yapabilirsiniz
        </Text>
        <Text fontSize="md" mb={2}>
          - Emanet ve stok bilgilerini yönetebilirsiniz
        </Text>
        <Text fontSize="md" mb={2}>
          - Favori kitaplarınızı ve okuma listelerinizi oluşturabilirsiniz
        </Text>
        <Text fontSize="md">- Kullanıcı dostu arayüz</Text>
      </Box>
    </Flex>
  );
};

export default IndexPage;

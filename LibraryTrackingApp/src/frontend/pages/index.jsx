import React from "react";
import { Box, Flex, Heading, Text, VStack } from "@chakra-ui/react";
import { NextSeo } from "next-seo";
import Features from "@/components/Features";

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
    <Flex align="center" justify="center" direction="column" px={8}>
      <Box mt={5}>
        <Features />
      </Box>
    </Flex>
  );
};

export default IndexPage;

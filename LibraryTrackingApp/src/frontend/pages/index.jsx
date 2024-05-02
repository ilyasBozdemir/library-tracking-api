import React from "react";
import { Box, Flex } from "@chakra-ui/react";
import { NextSeo } from "next-seo";
import Features from "@/layouts/Anon/components/Features";
import HeroSection from "@/layouts/Anon/components/HeroSection";
import LibraryStats from "@/layouts/Anon/components/LibraryStats";
import Testimonials from "@/layouts/Anon/components/Testimonials";
import LibraryPricing from "@/layouts/Anon/components/LibraryPricing";
import OverviewSection from "@/layouts/Anon/components/OverviewSection";

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
        <HeroSection />

        <LibraryStats />
        <Features />
        <LibraryPricing />
        <OverviewSection />
        <Testimonials />
      </Box>
    </Flex>
  );
};

export default IndexPage;

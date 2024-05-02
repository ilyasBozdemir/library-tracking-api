import { Fragment } from "react";
import {
  chakra,
  Container,
  Stack,
  Text,
  useColorModeValue,
  Link as CLink,
  Icon,
  Flex,
  Box,
} from "@chakra-ui/react";

import { FaGithub } from "react-icons/fa";
import { FaCircleNodes } from "react-icons/fa6";

import { RiNextjsLine } from "react-icons/ri";
import { AiOutlineDotNet } from "react-icons/ai";
import Link from "next/link";
const features = [
  {
    title: "Next.js ile Güçlendirilmiş",
    detail:
      "Next.js ile oluşturulan hızlı, etkileşimli ve SEO dostu web uygulamaları.",
    icon: <Icon as={RiNextjsLine} boxSize={8} color="white" />,
  },
  {
    title: ".NET Core Backend",
    detail:
      ".NET Core kullanarak güçlü ve ölçeklenebilir bir backend oluşturun.",
    icon: <Icon as={AiOutlineDotNet} boxSize={8} color="white" />,
  },
  {
    title: "Kolay Özelleştirme",
    detail: "Tüm bileşenler ve kancalar türleri ihraç eder.",
    icon: <Icon as={FaCircleNodes} boxSize={8} color="white" />,
  },
];
const HeroSection = () => {
  return (
    <Fragment>
      <Container maxW="6xl" px={{ base: 6, md: 10 }} py={14}>
        <Stack direction={{ base: "column", md: "row" }}>
          <Stack direction="column" spacing={10} justifyContent="center">
            <chakra.h1
              fontSize="5xl"
              lineHeight={1}
              fontWeight="bold"
              textAlign="left"
            >
              Kütüphane Yönetim Sistemi
            </chakra.h1>
            <Text
              color={useColorModeValue("gray.500", "gray.400")}
              fontSize="lg"
              textAlign="left"
              fontWeight="400"
              maxW="700px"
            >
              Hızlı ve etkili bir şekilde kütüphanenizi yönetin. Kolay kullanım
              ve esnek özelliklerle kütüphane işlerinizi düzenleyin.
            </Text>
            <Stack
              direction={{ base: "column", md: "row" }}
              spacing={{ base: 5, md: 10 }}
              flexWrap="wrap"
            >
              {features.map((feature, index) => (
                <Stack
                  key={index}
                  direction={{ base: "row", md: "column" }}
                  spacing={2}
                >
                  <Flex
                    p={3}
                    maxH="52px"
                    w="max-content"
                    color="white"
                    bgGradient="linear(to-br, #228be6, #15aabf)"
                    rounded="md"
                  >
                    {feature.icon}
                  </Flex>
                  <Stack direction="column" spacing={2}>
                    <Text fontSize="md" fontWeight="500">
                      {feature.title}
                    </Text>
                    <Text
                      fontSize="sm"
                      color="gray.400"
                      maxW={{ base: "100%", md: "200px" }}
                    >
                      {feature.detail}
                    </Text>
                  </Stack>
                </Stack>
              ))}
            </Stack>
            <Stack
              direction={{ base: "column", sm: "row" }}
              spacing={{ base: 0, sm: 2 }}
              flexWrap="wrap"
            >
              <CLink
                as={Link}
                href={"/login"}
              >
                <chakra.button
                  h={12}
                  px={6}
                  bgGradient="linear(to-br, #228be6, #15aabf)"
                  color="white"
                  _hover={{ bgGradient: "linear(to-br, #228be6, #228be6)" }}
                  variant="solid"
                  size="lg"
                  rounded="md"
                  fontWeight="bold"
                  mb={{ base: 2, sm: 0 }}
                >
                  <chakra.span> Şimdi Başlayalım! </chakra.span>
                </chakra.button>
              </CLink>
              <Flex
                border="1px solid"
                borderColor="gray.700"
                justifyContent="center"
                p={3}
                px={4}
                lineHeight={1.18}
                rounded="md"
                boxShadow="md"
                fontWeight="bold"
                alignItems="center"
              >
                <CLink
                  as={Link}
                  href={"https://github.com/ilyasbozdemir/libraryTrackingApp"}
                  rel={"noopener noreferrer"}
                  target="_blank"
                >
                  <Icon as={FaGithub} h={4} w={4} />
                  <chakra.span ml={1}> Github</chakra.span>
                </CLink>
              </Flex>
            </Stack>
          </Stack>
        </Stack>
      </Container>
      <Box overflow="hidden">
        <svg
          fill={useColorModeValue("#f7fafc", "#171923")}
          width="150%"
          height="56px"
          transform="scaleX(-1)"
          filter="drop-shadow(10px 5px 5px rgba(0, 0, 0, 0.05))"
          preserveAspectRatio="none"
          viewBox="0 0 1200 120"
          xmlns="http://www.w3.org/2000/svg"
        >
          <path
            d={`M321.39 56.44c58-10.79 114.16-30.13 172-41.86 82.39-16.72 168.19-17.73 
            250.45-.39C823.78 31 906.67 72 985.66 92.83c70.05 18.48 146.53 26.09 214.34 
            3V0H0v27.35a600.21 600.21 0 00321.39 29.09z`}
          ></path>
        </svg>
      </Box>
    </Fragment>
  );
};

export default HeroSection;

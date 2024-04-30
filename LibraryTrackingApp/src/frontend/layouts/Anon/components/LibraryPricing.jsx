import {
  chakra,
  VStack,
  HStack,
  Text,
  Container,
  Box,
  Icon,
  Button,
  SimpleGrid,
  useColorModeValue,
} from "@chakra-ui/react";
import { BiCheck } from "react-icons/bi";
import { IconType } from "react-icons";

const plansList = [
  {
    title: "Ücretsiz",
    price: "0.00",
    icon: BiCheck,
    features: [
      "Sınırsız kitap erişimi",
      "Sesli kitap dinleme",
      "PDF kitap okuma",
      "Kütüphane oluşturma ve paylaşma",
      "Öneri ve incelemeler",
      "Sosyal etkileşim ve topluluk katılımı",
      "Ücretsiz deneme ve örnek bölümler",
      "İşaretler ve ilerleme takibi",
    ],
  },
];

const LibraryPricing = () => {
  return (
    <Container maxW="7xl" py="8" px="0">
      <chakra.h2 fontSize="5xl" fontWeight="bold" textAlign="center" mb={5}>
        Premium Plan
      </chakra.h2>
      <SimpleGrid columns={{ base: 1, md: 1 }} spacing={1} mt={4}>
        {plansList.map((plan, index) => (
          <PricingCard key={index} {...plan} />
        ))}
      </SimpleGrid>
    </Container>
  );
};

const PricingCard = ({ title, price, icon, features }) => {
  return (
    <Box
      minW={{ base: "xs", sm: "xs", lg: "sm" }}
      rounded="md"
      bg={useColorModeValue("white", "gray.800")}
      boxShadow="md"
      marginInline="auto"
      my={3}
      p={6}
    >
      <Box textAlign="center">
        <Icon as={icon} h={10} w={10} color="teal.500" />
        <chakra.h2 fontSize="2xl" fontWeight="bold">
          {title}
        </chakra.h2>
        <Box fontSize="7xl" fontWeight="bold">
          <Text as="sup" fontSize="3xl" fontWeight="normal" top="-1em">
            ₺
          </Text>

          {price}
        </Box>
        <Text fontSize="md" color="gray.500">
          Ömür Boyu
        </Text>
      </Box>
      <VStack spacing={2} alignItems="flex-start" my={6}>
        {features.map((feature, index) => (
          <HStack key={index} spacing={3}>
            <Icon as={BiCheck} h={4} w={4} color="green.500" />
            <Text fontSize="sm" color="gray.500">
              {feature}
            </Text>
          </HStack>
        ))}
      </VStack>
      <Button
        colorScheme="teal"
        variant="solid"
        size="md"
        rounded="md"
        w="100%"
      >
        Şimdi Deneyin
      </Button>
    </Box>
  );
};

export default LibraryPricing;

import {
  chakra,
  Container,
  Stack,
  HStack,
  VStack,
  Flex,
  Text,
  Image,
  Box,
} from "@chakra-ui/react";

const overviewList = [
  {
    id: 1,
    label: "Kayıt Ol",
    subLabel: "Hesap oluşturmak için gerekli bilgileri girin.",
  },
  {
    id: 2,
    label: "Kitapları Yönet",
    subLabel:
      "Kendi kütüphanenizi oluşturun, kitapları ekleyin, düzenleyin veya kaldırın.",
  },
  {
    id: 3,
    label: "Emanet Ver ve Al",
    subLabel:
      "Kitaplarınızı başkalarına emanet verin veya başkalarından emanet alın.",
  },
  {
    id: 4,
    label: "Üye Ekle",
    subLabel: "Kütüphaneye yeni üyeler ekleyin ve hesaplarını yönetin.",
  },
];
const OverviewSection = () => {
  return (
    <Container maxW="6xl" py={10}>
      <chakra.h2 fontSize="4xl" fontWeight="bold" textAlign="center" mb={2}>
        Nasıl Çalışır?
      </chakra.h2>
      <Stack
        direction={{ base: "column", md: "row" }}
        spacing={{ base: 0, md: 3 }}
        justifyContent="center"
        alignItems="center"
      >
        <VStack
          spacing={4}
          alignItems="flex-start"
          mb={{ base: 5, md: 0 }}
          maxW="md"
        >
          {overviewList.map((data) => (
            <Box key={data.id}>
              <HStack spacing={2}>
                <Flex
                  fontWeight="bold"
                  boxShadow="md"
                  color="white"
                  bg="blue.400"
                  rounded="full"
                  justifyContent="center"
                  alignItems="center"
                  w={10}
                  h={10}
                >
                  {data.id}
                </Flex>
                <Text fontSize="xl">{data.label}</Text>
              </HStack>
              <Text fontSize="md" color="gray.500" ml={12}>
                {data.subLabel}
              </Text>
            </Box>
          ))}
        </VStack>
        <Image
          boxSize={{ base: "auto", md: "lg" }}
          objectFit="contain"
          src="/app-panel.png"
          rounded="lg"
        />
      </Stack>
    </Container>
  );
};

export default OverviewSection;

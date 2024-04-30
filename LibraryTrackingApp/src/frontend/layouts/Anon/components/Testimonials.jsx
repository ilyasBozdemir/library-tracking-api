import { Fragment } from "react";
import {
  Container,
  Box,
  chakra,
  Flex,
  Text,
  VStack,
  Avatar,
  Divider,
} from "@chakra-ui/react";

const testimonials = [
  {
    name: "Ahmet Yılmaz",
    position: "Kütüphane Müdürü",
    company: "Kütüphane A.Ş.",
    image:
      "link_to_image1.jpg",
    content: `Kütüphanemizdeki geniş kitap koleksiyonu ve kaliteli hizmet anlayışıyla her zaman yanınızdayız.`,
  },
  {
    name: "Ayşe Kaya",
    position: "Kütüphane Üyesi",
    company: "Kütüphane A.Ş.",
    image:
      "link_to_image2.jpg",
    content: `Kütüphanemizde bulunan kitaplar sayesinde kendimi sürekli geliştirme fırsatı buluyorum. Teşekkürler Kütüphane A.Ş.`,
  },
];

const Testimonials = () => {
  return (
    <Container maxW="5xl" p={{ base: 5, md: 10 }}>
      <Flex justifyContent="center" mb={8}>
        <chakra.h3 fontSize="3xl" fontWeight="bold" mb={3}>
          Kullanıcı Yorumları
        </chakra.h3>
      </Flex>

      {testimonials.map((obj, index) => (
        <Fragment key={index}>
          <VStack spacing={3} pt={1} justifyContent="center">
            <Avatar
              size="xl"
              showBorder={true}
              borderColor="teal.400"
              name="avatar"
              src={obj.image}
            />
            <Box textAlign="center">
              <Text fontWeight="bold" fontSize="lg">
                {obj.name}
              </Text>
              <Text fontWeight="medium" fontSize="sm" color="gray.400">
                {obj.position}, {obj.company}
              </Text>
            </Box>
            <Box textAlign="center" maxW="4xl">
              <Text fontSize="md" fontWeight="medium">
                {obj.content}
              </Text>
            </Box>
          </VStack>
          {testimonials.length - 1 !== index && <Divider my={6} />}
        </Fragment>
      ))}

    </Container>
  );
};

export default Testimonials;

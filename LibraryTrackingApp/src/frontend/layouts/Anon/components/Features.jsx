import {
  Container,
  Box,
  chakra,
  Text,
  Icon,
  SimpleGrid,
  Heading,
} from "@chakra-ui/react";
import {
  MdLibraryBooks,
  MdOutlineLocalLibrary,
  MdOutlineAssignmentTurnedIn,
  MdOutlineFavorite,
  MdLocalOffer,
  MdPeopleOutline,
  MdBorderColor,
} from "react-icons/md";

const features = [
  {
    heading: "Geniş Kütüphane",
    content: "Binlerce kitabı keşfedin ve istediğiniz kitapları kolayca bulun.",
    icon: MdLibraryBooks,
  },
  {
    heading: "Kendi Kütüphanenizi Oluşturun",
    content: `Emanet ve stok bilgilerini yönetin, favori kitaplarınızı belirleyin.`,
    icon: MdOutlineLocalLibrary,
  },
  {
    heading: "Emanet İşlemleri",
    content:
      "Kitapları kimin aldığını ve ne zaman geri getireceğini takip edin.",
    icon: MdOutlineAssignmentTurnedIn,
  },
  {
    heading: "Favori Kitaplarınızı Belirleyin",
    content: `Beğendiğiniz kitapları favorilerinize ekleyin ve daha sonra kolayca erişin.`,
    icon: MdOutlineFavorite,
  },
  {
    heading: "Şube Yönetimi",
    content:
      "Farklı şubeler oluşturun, kitapları şubeler arasında transfer edin.",
    icon: MdLocalOffer,
  },
  {
    heading: "Kitap Türleri Desteği",
    content: `Çeşitli kitap türlerine göre filtreleme yapın ve arama yapın.`,
    icon: MdBorderColor,
  },
  {
    heading: "Yazar Yönetimi",
    content:
      "Yazarları ekleyin, düzenleyin ve silin. Her yazarın eserlerini görüntüleyin.",
    icon: MdPeopleOutline,
  },
  {
    heading: "Yayıncı Yönetimi",
    content: `Kitap yayıncılarını ekleyin ve kitapların hangi yayınevlerinden geldiğini takip edin.`,
    icon: MdPeopleOutline,
  },
];

const Features = () => {
  return (
    <Container maxW="6xl" p={{ base: 5, md: 10 }}>
      <SimpleGrid
        columns={{ base: 1, md: 2 }}
        placeItems="center"
        spacing={16}
        mt={12}
        mb={4}
      >
        {features.map((feature, index) => (
          <Box key={index} textAlign="center">
            <Icon as={feature.icon} w={10} h={10} color="teal.400" />
            <chakra.h3 fontWeight="semibold" fontSize="2xl">
              {feature.heading}
            </chakra.h3>
            <Text fontSize="md">{feature.content}</Text>
          </Box>
        ))}
      </SimpleGrid>
    </Container>
  );
};

export default Features;

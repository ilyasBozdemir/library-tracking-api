import React from "react";
import { Box, Heading, Text, Image } from "@chakra-ui/react";
import { useRouter } from "next/router";

const publicLibraries = [
  {
    id: 1,
    name: "Merkez Kütüphane",
    location: "İstanbul",
    description: "Bu kütüphane...",
    image: "/kutuphane-istanbul.jpg",
    availableBooks: [
      { title: "Kitap 1", type: "Basılı Kitap" },
      { title: "Kitap 2", type: "E-Kitap" },
      { title: "Kitap 3", type: "Sesli Kitap" },
    ],
  },
  {
    id: 2,
    name: "Şehir Kütüphanesi",
    location: "Ankara",
    description: "Bu kütüphane...",
    image: "/kutuphane-ankara.jpg",
    availableBooks: [
      { title: "Kitap 4", type: "Basılı Kitap" },
      { title: "Kitap 5", type: "E-Kitap" },
      { title: "Kitap 6", type: "Sesli Kitap" },
    ],
  },
  // Diğer kütüphaneler buraya eklenebilir
];

function LibraryDetailPage() {
  const router = useRouter();
  const { id } = router.query;

  // Belirli bir kütüphane id'sine göre kütüphane detaylarını bulma
  const library = publicLibraries.find((library) => library.id == id);

  if (!library) {
    return <div>Kütüphane bulunamadı.</div>;
  }

  return (
    <Box p={4}>
      <Heading as="h1" size="xl" mb={4}>
        {library.name}
      </Heading>
      <Box display="flex" alignItems="center" mb={4}>
        <Image src={library.image} alt={library.name} boxSize="100px" mr={4} />
        <Text fontSize="lg">{library.location}</Text>
      </Box>
      <Text mb={4}>{library.description}</Text>
      <Heading as="h2" size="lg" mb={2}>
        Kütüphanedeki Kitaplar
      </Heading>
      {library.availableBooks.map((book, index) => (
        <Box key={index} mb={2}>
          <Text fontWeight="bold">{book.title}</Text>
          <Text>Tür: {book.type}</Text>
        </Box>
      ))}
    </Box>
  );
}

export default LibraryDetailPage;

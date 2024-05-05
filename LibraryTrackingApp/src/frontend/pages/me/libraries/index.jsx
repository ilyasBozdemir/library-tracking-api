import React, { useState } from "react";
import {
  Box,
  Heading,
  Text,
  Divider,
  Input,
} from "@chakra-ui/react";
import Link from "next/link";

const publicLibraries = [
  {
    id: 1,
    name: "Merkez Kütüphane",
    location: "İstanbul",
    description: "Bu kütüphane...",
    image: "/kutuphane-ankara.jpg",
  },
  {
    id: 1,
    name: "Şehir Kütüphanesi",
    location: "Ankara",
    description: "Bu kütüphane...",
    image: "/kutuphane-ankara.jpg",
  },
];

const LibrarySearch = ({ libraries }) => {
  const [searchTerm, setSearchTerm] = useState("");

  const filteredLibraries = libraries.filter((library) =>
    library.name.toLowerCase().includes(searchTerm.toLowerCase())
  );

  return (
    <Box p={4}>
      <Input
        placeholder="Kütüphane Ara"
        value={searchTerm}
        onChange={(e) => setSearchTerm(e.target.value)}
        mb={4}
      />
      {filteredLibraries.map((library, index) => (
        <Box
          key={index}
          borderWidth="1px"
          borderRadius="lg"
          p={4}
          mb={4}
          boxShadow="lg"
        >
          <Heading as="h3" size="md" mb={2}>
            {library.name}
          </Heading>
          <Text mb={2}>Konum: {library.location}</Text>

          <Link href={`/me/libraries/${library.id}`} passHref>
            <Text>Detaylar</Text>
          </Link>
          <Divider mt={2} />
        </Box>
      ))}
    </Box>
  );
};

const PublicLibraries = () => {
  return <LibrarySearch libraries={publicLibraries} />;
};

function MeLibraryPage() {
  return (
    <>
      <PublicLibraries />
    </>
  );
}

export default MeLibraryPage;

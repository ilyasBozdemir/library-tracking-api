import React, { useState } from 'react'
import { Box, Heading, Text, Button, Stack, Divider, Input } from "@chakra-ui/react";

const publicLibraries = [
  {
    name: "Merkez Kütüphane",
    location: "İstanbul",
    availableBooks: [
      { title: "Harry Potter and the Sorcerer's Stone", type: "Basılı Kitap" },
      { title: "1984", type: "E-Kitap" },
      { title: "The Great Gatsby", type: "Sesli Kitap" },
      // Diğer kitaplar buraya eklenebilir
    ]
  },
  {
    name: "Şehir Kütüphanesi",
    location: "Ankara",
    availableBooks: [
      { title: "To Kill a Mockingbird", type: "Basılı Kitap" },
      { title: "Pride and Prejudice", type: "E-Kitap" },
      // Diğer kitaplar buraya eklenebilir
    ]
  },
  // Diğer kütüphaneler buraya eklenebilir
];


const LibrarySearch = ({ libraries }) => {
  const [searchTerm, setSearchTerm] = useState('');

  const filteredLibraries = libraries.filter(library =>
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
        <Box key={index} borderWidth="1px" borderRadius="lg" p={4} mb={4} boxShadow="lg">
          <Heading as="h3" size="md" mb={2}>{library.name}</Heading>
          <Text mb={2}>Konum: {library.location}</Text>
          <Stack spacing={2}>
            {library.availableBooks.map((book, index) => (
              <Box key={index}>
                <Text fontWeight="bold">{book.title}</Text>
                <Text>Tür: {book.type}</Text>
              </Box>
            ))}
          </Stack>
          <Divider mt={2} />
        </Box>
      ))}
    </Box>
  );
};


const PublicLibraries = () => {
  return (
    <LibrarySearch libraries={publicLibraries} />
  );
};


function MeLibraryPage() {
  return (
    <>
    <PublicLibraries/>
    </>
  )
}

export default MeLibraryPage
import React, { useState } from 'react';
import { Box, Heading, Text, Button, Stack, Divider } from "@chakra-ui/react";

// Ödünç alınan kitapların örnek veri yapısı
const borrowedBooks = [
  {
    id: 1,
    title: "Harry Potter and the Sorcerer's Stone",
    author: "J.K. Rowling",
    dueDate: "2024-06-15",
    status: "Bekliyor"
  },
  {
    id: 2,
    title: "To Kill a Mockingbird",
    author: "Harper Lee",
    dueDate: "2024-06-20",
    status: "Uzatıldı"
  },
  // Diğer ödünç alınan kitaplar buraya eklenebilir
];

const BorrowPage = () => {
  const [extendedBooks, setExtendedBooks] = useState([]);

  // Kitap için uzatma isteği gönderme işlevi
  const handleExtend = (id) => {
    console.log(`Kitap ID${id} için takip süresi uzatma isteği gönderildi.`);
    // Uzatılan kitabı güncelle
    const updatedBooks = borrowedBooks.map(book =>
      book.id === id ? { ...book, status: "Uzatma İsteği Gönderildi" } : book
    );
    setExtendedBooks(updatedBooks);
  };

  return (
    <Box p={4}>
      <Heading as="h1" mb={4}>Ödünç Aldıklarım</Heading>
      <Stack spacing={4}>
        {borrowedBooks.map((book) => (
          <Box key={book.id} borderWidth="1px" borderRadius="md" p={4} mb={4}>
            <Heading as="h3" size="md" mb={2}>{book.title}</Heading>
            <Text mb={2}>Yazar: {book.author}</Text>
            <Text mb={2}>Son Teslim Tarihi: {book.dueDate}</Text>
            <Text>Status: {book.status}</Text>
            {book.status === "Bekliyor" && (
              <Button colorScheme="blue" onClick={() => handleExtend(book.id)}>Uzat</Button>
            )}
          </Box>
        ))}
      </Stack>
    </Box>
  );
};

export default BorrowPage;

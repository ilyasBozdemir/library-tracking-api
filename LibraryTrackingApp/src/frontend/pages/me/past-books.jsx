import React from 'react'
import { Box, Heading, Text, Stack, Divider } from "@chakra-ui/react";

const pastBooks = [
  {
    id: 1,
    title: "Harry Potter and the Sorcerer's Stone",
    author: "J.K. Rowling",
    returnDate: "2024-06-15",
  },
  {
    id: 2,
    title: "To Kill a Mockingbird",
    author: "Harper Lee",
    returnDate: "2024-06-20",
  },
  // Diğer önceki kitaplar buraya eklenebilir
];

function PastBooksPage() {
  return (
    <>
     <Box p={4}>
      <Heading as="h1" mb={4}>Geçmiş Kitaplarım</Heading>
      <Stack spacing={4}>
        {pastBooks.map((book) => (
          <Box key={book.id} borderWidth="1px" borderRadius="md" p={4} mb={4}>
            <Heading as="h3" size="md" mb={2}>{book.title}</Heading>
            <Text mb={2}>Yazar: {book.author}</Text>
            <Text mb={2}>İade Tarihi: {book.returnDate}</Text>
            <Divider />
          </Box>
        ))}
      </Stack>
    </Box>
    </>
  )
}

export default PastBooksPage
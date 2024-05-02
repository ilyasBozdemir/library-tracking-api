import React from "react";
import { Container, Heading, List, ListItem, Text } from "@chakra-ui/react";

const ReadingListPage = () => {
  const readingList = [
    { id: 1, title: "The Great Gatsby", author: "F. Scott Fitzgerald" },
    { id: 2, title: "Pride and Prejudice", author: "Jane Austen" },
    { id: 3, title: "The Catcher in the Rye", author: "J.D. Salinger" },

  ];

  return (
    <Container maxW="xl">
      <Heading as="h1" mb={4}>Okuma Listesi</Heading>
      <List spacing={3}>
        {readingList.map((item) => (
          <ListItem key={item.id}>
            <Text fontSize="lg" fontWeight="bold">{item.title}</Text>
            <Text>{item.author}</Text>
          </ListItem>
        ))}
      </List>
    </Container>
  );
};

export default ReadingListPage;

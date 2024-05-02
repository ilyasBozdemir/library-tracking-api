import React from "react";
import { Container, Heading, List, ListItem, Text } from "@chakra-ui/react";

const FavoritesPage = () => {
  const favorites = [
    { id: 1, title: "Harry Potter and the Philosopher's Stone", author: "J.K. Rowling" },
    { id: 2, title: "To Kill a Mockingbird", author: "Harper Lee" },
    { id: 3, title: "1984", author: "George Orwell" },
    
  ];

  return (
    <Container maxW="xl">
      <Heading as="h1" mb={4}>Favoriler</Heading>
      <List spacing={3}>
        {favorites.map((item) => (
          <ListItem key={item.id}>
            <Text fontSize="lg" fontWeight="bold">{item.title}</Text>
            <Text>{item.author}</Text>
          </ListItem>
        ))}
      </List>
    </Container>
  );
};

export default FavoritesPage;

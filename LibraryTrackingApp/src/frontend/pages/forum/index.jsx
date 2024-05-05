import React from 'react';
import Link from 'next/link';
import { Box, Heading, Text } from '@chakra-ui/react';


const categories = [
  { id: 1, name: 'Teknoloji', description: 'Teknoloji ile ilgili tartışmalar' },
  { id: 2, name: 'Spor', description: 'Spor ile ilgili tartışmalar' },
  { id: 3, name: 'Müzik', description: 'Müzik ile ilgili tartışmalar' },
];

const ForumIndexPage = () => {
    
  return (
    <Box p={4}>
      <Box>
        {categories.map(category => (
          <Box key={category.id} borderWidth="1px" borderRadius="lg" p={4} mb={4}>
            <Heading as="h2" size="lg" mb={2}>{category.name}</Heading>
            <Text>{category.description}</Text>
            <Link href={`/forum/${category.id}`} passHref>
              <Text mt={2} color="blue.500" cursor="pointer">Konuları Görüntüle</Text>
            </Link>
          </Box>
        ))}
      </Box>
    </Box>
  );
};

export default ForumIndexPage;

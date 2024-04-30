import * as React from 'react';
import { Container, Text, SimpleGrid, Box, Center } from '@chakra-ui/react';


// DB'ye ilerleyen zamanda bağlanıcaktır.

const libraryStats = [
  {
    id: 1,
    label: 'Toplam Kitap',
    score: '550'
  },
  {
    id: 2,
    label: 'Okuyucu Sayısı',
    score: '421'
  },
  {
    id: 3,
    label: 'Toplam Ödünç',
    score: '1,364'
  },
  {
    id: 4,
    label: 'Çalışanlar',
    score: '38'
  }
];

const LibraryStats = () => {
  return (
    <Container maxW="7xl" p={{ base: 5, md: 10 }}>
      <Center>
        <Box textAlign="center">
          <Text fontWeight="extrabold" fontSize="x-large" mb={2}>
            <Box as="span" display="inline-block" position="relative">
              Okuyucularımızın Tercihi
              <Box
                as="span"
                display="block"
                position="absolute"
                bg={'blue.600'}
                w={'100%'}
                h={'1px'}
              />
            </Box>
          </Text>
          <Text>Kütüphanemizdeki geniş kitap koleksiyonu ile sizlere en iyi okuma deneyimini sunuyoruz.</Text>
        </Box>
      </Center>
      <SimpleGrid columns={{ base: 1, sm: 2, md: 4 }} spacing={{ base: 2, sm: 5 }} mt={12} mb={4}>
        {libraryStats.map((data) => (
          <Box key={data.id} p={{ base: 2, sm: 5 }} textAlign="center">
            <Text fontWeight="extrabold" fontSize="xx-large">
              {data.score}
            </Text>
            <Text fontSize="sm">{data.label}</Text>
          </Box>
        ))}
      </SimpleGrid>
    </Container>
  );
};

export default LibraryStats;

import { Box, Text, Image } from '@chakra-ui/react';
import { useRouter } from 'next/router';

const MagazineDetail = ({ magazine }) => {
  const router = useRouter();

  if (!magazine) {
    return <Box>Loading...</Box>;
  }

  const handleEdit = () => {
    router.push(`/app/magazines/${magazine.id}/edit`);
  };

  return (
    <Box>
      <Box mb={4} display="flex" alignItems="center">
        <Text fontSize="2xl" fontWeight="bold">{magazine.name}</Text>
        <Box ml={2}>
          <Button colorScheme="teal" size="sm" onClick={handleEdit}>Düzenle</Button>
        </Box>
      </Box>
      <Box mb={4}>
        <Image src={magazine.coverImage} alt={magazine.name} />
      </Box>
      <Text fontSize="lg">{magazine.publicationDate}</Text>
      <Text mt={4}>{magazine.description}</Text>
    </Box>
  );
};

export default MagazineDetail;

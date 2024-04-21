import LibraryService from "@/services/authorService";
import { useRouter } from "next/router";
import { useEffect, useState } from "react";
import { Button, Box, Heading, Text, VStack } from "@chakra-ui/react";

function AuthorPage() {
  const router = useRouter();
  const { id } = router.query;
  const [author, setAuthor] = useState(null);
  const [error, setError] = useState(false);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const fetchedAuthor = await AuthorService.getAuthorById(id);
        setAuthor(fetchedAuthor.data);
        setError(false);
      } catch (error) {
        setError(true);
      }
    };

    if (id) {
      fetchData();
    }
  }, [id]);

  return (
    <>
      <Box
        maxW="xl"
        mx="auto"
        p={8}
        borderRadius="lg"
        bg="gray.100"
        boxShadow="xl"
      >
        <Heading as="h1" size="xl" mb={4}>
          Yazar Detayları
        </Heading>
        <VStack align="start" spacing={4}>
          <Text>
            <strong>Adı:</strong> {author?.name}
          </Text>
          <Text>
            <strong>Soyadı:</strong> {author?.surname}
          </Text>
          <Text>
            <strong>Doğum Tarihi:</strong> {author?.birthDate}
          </Text>
          <Text>
            <strong>Ülke:</strong> {author?.country}
          </Text>
          <Text>
            <strong>Biyografi:</strong> {author?.biography}
          </Text>
        </VStack>
      </Box>
      <VStack my={3}>
        <Button
          onClick={() => router.push("/admin/author")}
          colorScheme="orange"
          variant="outline"
        >
          Listeye Dön
        </Button>
      </VStack>
    </>
  );
}

export default AuthorPage;

import React from 'react'
import { useRouter } from "next/router";
import { useEffect, useState } from "react";
import { Button, Box, Heading,Divider, Text, VStack } from "@chakra-ui/react";
import LibraryService from '@/services/libraryService';


//güncellenecektir.

function LibraryDetailPage() {
  const router = useRouter();
  const { id } = router.query;
  const [library, setLibrary] = useState(null);
  const [error, setError] = useState(false);
  useEffect(() => {
    const fetchData = async () => {
      try {
        const fetchedLibrary = await LibraryService.getLibraryById(id);
        setLibrary(fetchedLibrary.data);
        setError(false);
      } catch (error) {
        setError(true);
      }
    };

    if (id) {
      fetchData();
    }
  }, [id]);

  console.table(library)
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
        <VStack align="stretch" spacing={4} p={4}>
          <Heading>{library?.name}</Heading>
          <Text>{library?.address}</Text>
          <Divider />
        </VStack>
      </Box>
      <VStack my={3}>
        <Button
          onClick={() => router.push("/admin/library")}
          colorScheme="orange"
          variant="outline"
        >
          Listeye Dön
        </Button>
      </VStack>
    </>
  )
}

export default LibraryDetailPage
// components/Error409.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error409 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>409 - Conflict</Text>
      <Text fontSize="lg" mb={8}>Oops! There was a conflict processing your request.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error409;

// components/Error501.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error501 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>501 - Not Implemented</Text>
      <Text fontSize="lg" mb={8}>Oops! This feature is not implemented yet.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error501;

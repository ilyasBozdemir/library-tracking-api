// components/Error502.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error502 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>502 - Bad Gateway</Text>
      <Text fontSize="lg" mb={8}>Oops! The server received an invalid response from an upstream server.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error502;

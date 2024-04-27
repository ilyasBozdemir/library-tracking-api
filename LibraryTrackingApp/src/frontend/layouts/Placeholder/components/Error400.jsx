// components/Error400.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error400 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>400 - Bad Request</Text>
      <Text fontSize="lg" mb={8}>Oops! Your request is invalid. Please check your input and try again.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error400;

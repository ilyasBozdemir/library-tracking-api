// components/Error404.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error404 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>404 - Page Not Found</Text>
      <Text fontSize="lg" mb={8}>Oops! The page you're looking for does not exist.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error404;

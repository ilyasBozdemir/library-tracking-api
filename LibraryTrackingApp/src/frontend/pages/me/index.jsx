import React from "react";

import {
  Flex,
  Box,
  Heading,
  Text,
  Button,
  IconButton,
  Spacer,
  Stack,
  Divider,
  Avatar,
  AvatarBadge,
  HStack,
} from "@chakra-ui/react";
import { FiSettings, FiLogOut } from "react-icons/fi";
import { FaRegHeart, FaRegListAlt } from "react-icons/fa";

const IndexPage = () => {

  const user = {
    name: "İlyas Bozdemir",
    username: "İlyas Bozdemir",
    email: "user@example.com",
    avatar: "https://avatars.githubusercontent.com/u/52322835?s=96&v=4",
    role: "Üye",
    status: "Aktif",
    bio: "Merhaba, ben İlyas. Kitap okumayı çok seviyorum ve bu platformda yeni kitaplar keşfetmeyi umuyorum.",
  };

  return (
    <Flex p={4}>
      <Box w="25%">
        <Avatar name={user.name} size="xl" src={user.avatar}>
          <AvatarBadge boxSize="1.25em" bg="green.500" />
        </Avatar>
        <Heading as="h3" mt={4} mb={2} fontSize="xl">
          {user.username}
        </Heading>
        <Text color="gray.500">Premium Üye</Text>
        <Flex justify="center" align="center" mt={4}>
          <Button leftIcon={<FiSettings />} colorScheme="teal">
            Profili Düzenle
          </Button>
          <IconButton
            ml={3}
            aria-label="Çıkış Yap"
            icon={<FiLogOut />}
            colorScheme="red"
          />
        </Flex>

      </Box>
      <Spacer />
      <Box w="50%" borderWidth="1px" borderRadius="md" p={4}>
        <Heading as="h3" mb={4} fontSize="xl">
          Favori Kitaplar
        </Heading>
        <Stack spacing={2}>
          <Box>
            <Text fontWeight="bold">1. Harry Potter ve Felsefe Taşı</Text>
            <Text color="gray.500">J.K. Rowling</Text>
          </Box>
          <Divider />
          <Box>
            <Text fontWeight="bold">2. Hobbit</Text>
            <Text color="gray.500">J.R.R. Tolkien</Text>
          </Box>
          <Divider />
          <Box>
            <Text fontWeight="bold">3. Suç ve Ceza</Text>
            <Text color="gray.500">Fyodor Dostoyevski</Text>
          </Box>
        </Stack>
        <Button mt={4} leftIcon={<FaRegHeart />} colorScheme="teal">
          Tüm Favorileri Görüntüle
        </Button>
      </Box>
      <Spacer />
      <Box w="25%" borderWidth="1px" borderRadius="md" p={4}>
        <Heading as="h3" mb={4} fontSize="xl">
          Okuma Listesi
        </Heading>
        <Stack spacing={2}>
          <Box>
            <Text fontWeight="bold">1. Uyanış</Text>
            <Text color="gray.500">Leo Tolstoy</Text>
          </Box>
          <Divider />
          <Box>
            <Text fontWeight="bold">2. 1984</Text>
            <Text color="gray.500">George Orwell</Text>
          </Box>
          <Divider />
          <Box>
            <Text fontWeight="bold">3. Uçurtma Avcısı</Text>
            <Text color="gray.500">Khaled Hosseini</Text>
          </Box>
        </Stack>
        <Button mt={4} leftIcon={<FaRegListAlt />} colorScheme="teal">
          Tümünü Görüntüle
        </Button>
      </Box>
    </Flex>
  );
};

export default IndexPage;

import React from 'react'

import { Box, Flex, Avatar, Text, Badge } from "@chakra-ui/react";

const user = {
  name: "İlyas Bozdemir",
  email: "user@example.com",
  avatar: "https://avatars.githubusercontent.com/u/52322835?s=96&v=4",
  role: "Manager",
  status: "Aktif",
  bio: "Merhaba, ben İlyas. Kitap okumayı çok seviyorum ve bu platformda yeni kitaplar keşfetmeyi umuyorum.",
};


const ProfileCard = ({ user }) => {
    return (
        <Box borderWidth="1px" borderRadius="lg" p={4} boxShadow="lg">
            <Flex alignItems="center">
                <Avatar size="xl" name={user.name} src={user.avatar} mr={4} />
                <Box>
                    <Text fontSize="2xl" fontWeight="bold">{user.name}</Text>
                    <Text fontSize="md" color="gray.600">{user.email}</Text>
                    <Flex mt={2}>
                        <Badge colorScheme="green" mr={2}>{user.role}</Badge>
                        <Badge colorScheme="blue">{user.status}</Badge>
                    </Flex>
                </Box>
            </Flex>
            <Box mt={4}>
                <Text fontSize="md">{user.bio}</Text>
            </Box>
        </Box>
    );
};

function MyProfilePage() {
  return (
    <>
    <ProfileCard user={user}/>
    </>
  )
}

export default MyProfilePage
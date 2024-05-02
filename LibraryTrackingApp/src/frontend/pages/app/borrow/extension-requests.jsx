import React from 'react';
import { Box, Heading, Text, Badge, HStack, Button } from "@chakra-ui/react";

const ExtensionRequestsPage = () => {

    // Backend ile bağlantı sağlandığında uzatma isteklerinin alındığı bir liste oluşturulacak
    const extensionRequests = [
        {
            id: 1,
            bookTitle: "Sefiller",
            userName: "John Doe",
            requestDate: "2024-05-20",
            status: "Beklemede",
        },
        {
            id: 2,
            bookTitle: "Harry Potter and the Sorcerer's Stone",
            userName: "Alice Smith",
            requestDate: "2024-05-22",
            status: "Uzatıldı",
        },
        {
            id: 3,
            bookTitle: "Lord of the Rings",
            userName: "Emily Brown",
            requestDate: "2024-05-25",
            status: "Reddedildi",
        },
    ];

    const handleAccept = (id) => {
        console.log(`Uzatma isteği ID${id} onaylandı.`);
    };

    const handleReject = (id) => {
        console.log(`Uzatma isteği ID${id} reddedildi.`);
    };

    return (
        <Box p={4}>
            <Heading as="h1" mb={4}>Uzatma İstekleri</Heading>
            <Text mb={4}>Aşağıda kullanıcıların gönderdiği uzatma istekleri listelenmektedir.</Text>
            {extensionRequests.map((request) => (
                <Box key={request.id} borderWidth="1px" borderRadius="md" p={4} mb={4}>
                    <Heading as="h3" size="md" mb={2}>Kitap: {request.bookTitle}</Heading>
                    <Text mb={2}>Kullanıcı: {request.userName}</Text>
                    <Text mb={2}>İstek Tarihi: {request.requestDate}</Text>
                    <HStack spacing={4}>
                        <Badge colorScheme={request.status === "Beklemede" ? "yellow" : request.status === "Uzatıldı" ? "green" : "red"}>
                            {request.status}
                        </Badge>
                        {request.status === "Beklemede" && (
                            <>
                                <Button colorScheme="green" size="sm" onClick={() => handleAccept(request.id)}>Onayla</Button>
                                <Button colorScheme="red" size="sm" onClick={() => handleReject(request.id)}>Reddet</Button>
                            </>
                        )}
                    </HStack>
                </Box>
            ))}
        </Box>
    );
};

export default ExtensionRequestsPage;

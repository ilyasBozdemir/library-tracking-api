import MagazineEditForm from "@/components/MagazineEditForm";
import { Box, Image, Text, VStack, Button, HStack } from "@chakra-ui/react";
import { useState } from "react";


const MagazineList = ({ magazines }) => {
  const [isEditModalOpen, setIsEditModalOpen] = useState(false);
  const [selectedMagazine, setSelectedMagazine] = useState(null);

  const handleEditClick = (magazine) => {
    setSelectedMagazine(magazine);
    setIsEditModalOpen(true);
  };

  const handleCloseModal = () => {
    setSelectedMagazine(null);
    setIsEditModalOpen(false);
  };

  const handleUpdateMagazine = (updatedMagazine) => {
    console.log("Güncellenen dergi:", updatedMagazine);
    setIsEditModalOpen(false);
  };

  return (
    <HStack align="start" spacing={4}>
      {magazines.map((magazine) => (
        <Box key={magazine.id} boxShadow="md" p={4}>
          <Image src={magazine.coverImage} alt={magazine.name} />
          <Text fontWeight="bold">{magazine.name}</Text>
          <Text>{magazine.publicationDate}</Text>
          <Button colorScheme="teal" size="sm" onClick={() => handleEditClick(magazine)}>
            Düzenle
          </Button>
        </Box>
      ))}
      <MagazineEditForm
        magazine={selectedMagazine}
        isOpen={isEditModalOpen}
        onClose={handleCloseModal}
        onSubmit={handleUpdateMagazine}
      />
    </HStack>
  );
};
export async function getServerSideProps() {
  const magazines = [
    {
      id: 1,
      name: "National Geographic",
      coverImage: "https://via.placeholder.com/300x200",
      publicationDate: "Mayıs 2024",
    },
    {
      id: 2,
      name: "Time",
      coverImage: "https://via.placeholder.com/300x200",
      publicationDate: "Nisan 2024",
    },
    {
      id: 3,
      name: "Vogue",
      coverImage: "https://via.placeholder.com/300x200",
      publicationDate: "Mart 2024",
    },
  ];

  return {
    props: {
      magazines,
    },
  };
}

export default MagazineList;

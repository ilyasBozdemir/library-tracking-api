import { useState, useEffect } from 'react';
import { Table, Thead, Tbody, Tr, Th, Td, Button, Modal, ModalOverlay, ModalContent, ModalHeader, ModalFooter, ModalBody, ModalCloseButton, FormControl, FormLabel, Input } from '@chakra-ui/react';
import { MdEdit, MdDelete } from 'react-icons/md';

function BranchesPage() {
  const [branches, setBranches] = useState([]);
  const [isOpen, setIsOpen] = useState(false);
  const [newBranch, setNewBranch] = useState({ name: '', address: '' });

  useEffect(() => {
    const sampleBranches = [
      { id: 1, name: 'Şube 1', address: 'Adres 1' },
      { id: 2, name: 'Şube 2', address: 'Adres 2' },
      { id: 3, name: 'Şube 3', address: 'Adres 3' },
    ];
    setBranches(sampleBranches);
  }, []);

  const handleOpenModal = () => {
    setIsOpen(true);
  };

  const handleCloseModal = () => {
    setIsOpen(false);
  };

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setNewBranch({ ...newBranch, [name]: value });
  };

  const handleAddBranch = () => {

    const updatedBranches = [...branches, { id: branches.length + 1, ...newBranch }];
    setBranches(updatedBranches);
    setIsOpen(false);
    setNewBranch({ name: '', address: '' });
  };

  return (
    <div>
      <Button onClick={handleOpenModal}>Yeni Ekle</Button>

      <Table variant="simple">
        <Thead>
          <Tr>
            <Th>ID</Th>
            <Th>Şube Adı</Th>
            <Th>Adres</Th>
            <Th>İşlemler</Th>
          </Tr>
        </Thead>
        <Tbody>
          {branches.map((branch) => (
            <Tr key={branch.id}>
              <Td>{branch.id}</Td>
              <Td>{branch.name}</Td>
              <Td>{branch.address}</Td>
              <Td>
                <Button leftIcon={<MdEdit />} mr={2} variant="outline">
                  Düzenle
                </Button>
                <Button leftIcon={<MdDelete />} variant="outline">
                  Sil
                </Button>
              </Td>
            </Tr>
          ))}
        </Tbody>
      </Table>

      <Modal isOpen={isOpen} onClose={handleCloseModal}>
        <ModalOverlay />
        <ModalContent>
          <ModalHeader>Yeni Şube Ekle</ModalHeader>
          <ModalCloseButton />
          <ModalBody>
            <FormControl>
              <FormLabel>Şube Adı</FormLabel>
              <Input type="text" name="name" value={newBranch.name} onChange={handleInputChange} />
            </FormControl>
            <FormControl mt={4}>
              <FormLabel>Adres</FormLabel>
              <Input type="text" name="address" value={newBranch.address} onChange={handleInputChange} />
            </FormControl>
          </ModalBody>
          <ModalFooter>
            <Button colorScheme="blue" onClick={handleAddBranch}>
              Ekle
            </Button>
          </ModalFooter>
        </ModalContent>
      </Modal>
    </div>
  );
}

export default BranchesPage;

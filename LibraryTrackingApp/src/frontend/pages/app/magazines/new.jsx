import { useState } from 'react';
import { Box, Button, FormControl, FormLabel, Input, Text } from '@chakra-ui/react';

const MagazineForm = ({ onAdd }) => {
  const [name, setName] = useState('');
  const [publicationDate, setPublicationDate] = useState('');
  const [coverImage, setCoverImage] = useState(null);
  const [error, setError] = useState('');

  const handleAddMagazine = () => {
    if (!name || !publicationDate || !coverImage) {
      setError('Lütfen tüm alanları doldurun.');
      return;
    }
    onAdd({ name, publicationDate, coverImage });
    setName('');
    setPublicationDate('');
    setCoverImage(null);
    setError('');
  };

  const handleFileChange = (e) => {
    const selectedFile = e.target.files[0];
    if (selectedFile) {
      setCoverImage(selectedFile);
      setError('');
    } else {
      setCoverImage(null);
      setError('Lütfen bir dosya seçin.');
    }
  };

  return (
    <Box>
      <FormControl>
        <FormLabel htmlFor="name">Dergi Adı</FormLabel>
        <Input type="text" id="name" value={name} onChange={(e) => setName(e.target.value)} />
      </FormControl>
      <FormControl mt={4}>
        <FormLabel htmlFor="publicationDate">Yayın Tarihi</FormLabel>
        <Input type="date" id="publicationDate" value={publicationDate} onChange={(e) => setPublicationDate(e.target.value)} />
      </FormControl>
      <FormControl mt={4}>
        <FormLabel htmlFor="coverImage">Kapak Fotoğrafı</FormLabel>
        <Input type="file" id="coverImage" onChange={handleFileChange} />
      </FormControl>
      {error && <Text color="red.500">{error}</Text>}
      <Button mt={4} colorScheme="blue" onClick={handleAddMagazine}>Ekle</Button>
    </Box>
  );
};

export default MagazineForm;

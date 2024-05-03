import { useState } from 'react';
import { Box, Button, Text } from '@chakra-ui/react';
import { MdCloudUpload } from 'react-icons/md';

const UploadForm = ({ onUpload, labelName,accept }) => {
  const [file, setFile] = useState(null);
  const [error, setError] = useState('');

  const handleFileChange = (e) => {
    const selectedFile = e.target.files[0];
    if (selectedFile) {
      setFile(selectedFile);
      setError('');
    } else {
      setFile(null);
      setError('Lütfen bir dosya seçin.');
    }
  };

  const handleUpload = () => {
    if (!file) {
      setError('Lütfen bir dosya seçin.');
      return;
    }
    onUpload(file);
    setFile(null);
  };

  const handleDrop = (e) => {
    e.preventDefault();
    const droppedFile = e.dataTransfer.files[0];
    if (droppedFile) {
      setFile(droppedFile);
      setError('');
    } else {
      setFile(null);
      setError('Lütfen bir dosya sürükleyip bırakın.');
    }
  };

  const handleDragOver = (e) => {
    e.preventDefault();
  };

  return (
    <Box
      border="2px dashed"
      borderColor="gray.200"
      borderRadius="md"
      p={6}
      textAlign="center"
      position="relative"
      cursor="pointer"
      _hover={{ bg: 'gray.50' }}
      onDrop={handleDrop}
      onDragOver={handleDragOver}
    >
      <input
        type="file"
        id="file"
        accept={accept}
        onChange={handleFileChange}
        style={{ display: 'none' }}
      />
      <label htmlFor="file">
        <MdCloudUpload size={24} />
        <Text fontSize="sm" mt={2} fontWeight={'semibold'}>
          {labelName}
        </Text>
      </label>
      {error && <Text color="red.500">{error}</Text>}
      {file && (
        <Text mt={2} fontWeight="bold">
          {file.name} ({(file.size / 1024 / 1024).toFixed(2)} MB)
        </Text>
      )}
      <Button
        mt={4}
        colorScheme="blue"
        onClick={handleUpload}
        isDisabled={!file}
      >
        Yükle
      </Button>
    </Box>
  );
};

export default UploadForm;

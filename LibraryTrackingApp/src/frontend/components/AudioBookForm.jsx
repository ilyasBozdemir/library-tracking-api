import { useState } from "react";
import {
  Box,
  FormControl,
  FormLabel,
  Input,
  Table,
  TableCaption,
  Tbody,
  Textarea,
  Th,
  Thead,
  Tr,
} from "@chakra-ui/react";
import UploadForm from "./UploadForm";

const AudioBookForm = ({ onUpload }) => {
  const [title, setTitle] = useState("");
  const [author, setAuthor] = useState("");
  const [narrator, setNarrator] = useState("");
  const [description, setDescription] = useState("");
  const [audioFile, setAudioFile] = useState(null);
  const [audioFiles, setAudioFiles] = useState([]);

  const handleUpload = (file) => {
    // ayarlanacak..
  };
  const handleDelete = (id) => {
    setAudioFiles(eBooks.filter((audioFile) => audioFile.id !== id));
  };
  return (
    <>
      <FormControl>
        <FormLabel htmlFor="title">Başlık</FormLabel>
        <Input
          type="text"
          id="title"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
        />
      </FormControl>
      <FormControl mt={4}>
        <FormLabel htmlFor="author">Yazar</FormLabel>
        <Input
          type="text"
          id="author"
          value={author}
          onChange={(e) => setAuthor(e.target.value)}
        />
      </FormControl>
      <FormControl mt={4}>
        <FormLabel htmlFor="narrator">Anlatan</FormLabel>
        <Input
          type="text"
          id="narrator"
          value={narrator}
          onChange={(e) => setNarrator(e.target.value)}
        />
      </FormControl>
      <FormControl mt={4}>
        <FormLabel htmlFor="description">Açıklama</FormLabel>
        <Textarea
          id="description"
          value={description}
          onChange={(e) => setDescription(e.target.value)}
        />
      </FormControl>

      <UploadForm
        onUpload={handleUpload}
        //accept=".mp3, .wav"
        labelName={"Ses Dosyasını buraya bırakınız."}
      />

      <Table variant="striped" colorScheme="blue" mt={8}>
        <TableCaption>{`${audioFiles.length} sesli kitap bulundu.`}</TableCaption>
        <Thead>
          <Tr>
            <Th>Ad</Th>
            <Th>Dosya Tipi</Th>
            <Th>Boyut (KB)</Th>
            <Th>İşlemler</Th>
          </Tr>
        </Thead>
        <Tbody>
          {audioFiles.map((file) => (
            <Tr key={file.id}>
              <Td>{file.title}</Td>
              <Td>{file.author}</Td>
              <Td>{(file.size / 1024).toFixed(2)}</Td>
              <Td>{file.author}</Td>

              <Td>
                <Button
                  colorScheme="teal"
                  size="sm"
                  mr={2}
                  onClick={() => window.open(`/app/e-books/${file.id}`)}
                >
                  Görüntüle
                </Button>
                <Button
                  colorScheme="red"
                  size="sm"
                  onClick={() => handleDelete(file.id)}
                >
                  Sil
                </Button>
              </Td>
            </Tr>
          ))}
        </Tbody>
      </Table>
    </>
  );
};

export default AudioBookForm;

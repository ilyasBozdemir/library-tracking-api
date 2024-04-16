import { Flex, Heading, Grid, GridItem, Text,Box, Link as ChakraLink } from '@chakra-ui/react';
import Link from 'next/link';

function AdminIndexPage() {

  const items = [
    { title: 'Kütüphane', description: 'Kütüphane bilgilerini düzenleyin, yeni kütüphaneler ekleyin.', link: '/admin/library' },
    { title: 'Üyeler', description: 'Üyeleri yönetin, yeni üyeler ekleyin.', link: '/admin/members' },
    { title: 'Kitaplar', description: 'Kitapları düzenleyin, yeni kitaplar ekleyin.', link: '/admin/books' },
    { title: 'Personel', description: 'Personel bilgilerini yönetin, yeni personel ekleyin.', link: '/admin/staff' },
    { title: 'Ödünç Verme', description: 'Kitap ödünç verme işlemlerini yönetin.', link: '/admin/borrow' },
    { title: 'Kitap Türleri', description: 'Kitap türlerini düzenleyin, yeni türler ekleyin.', link: '/admin/genres' },
    { title: 'Kitap Etiketleri', description: 'Arama terimlerini yönetin, popüler arama terimlerini görüntüleyin ve düzenleyin.', link: '/admin/book-tags' },
  ];

  return (
    <Flex direction="column" alignItems="center" justifyContent="center">
      <Heading as="h1" size="2xl" textAlign="center" mb={4}>
        Hoş Geldiniz!
      </Heading>
      <Text fontSize="xl" textAlign="center" mb={8}>
        Bu, kütüphane yönetim paneline hoş geldiniz. Buradan kütüphane, üye, kitap, personel ve diğer kaynakları yönetebilirsiniz.
      </Text>
      <Grid templateColumns={{ base: 'repeat(1, 1fr)', md: 'repeat(3, 1fr)' }} gap={6}>
        {items.map((item, index) => (
          <GridItem key={index}>
            <Box bg="gray.200" p={8} borderRadius="lg" textAlign="center">
              <Heading as="h2" size="lg" mb={4}>{item.title}</Heading>
              <Text fontSize="md">{item.description}</Text>
              <ChakraLink as={Link} href={item.link} mt={4} color="blue.500" textDecoration="underline">Detaylar</ChakraLink>
            </Box>
          </GridItem>
        ))}
      </Grid>
    </Flex>
  );
}

export default AdminIndexPage;

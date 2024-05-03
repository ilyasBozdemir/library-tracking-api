import {
  Box,
  Flex,
  Heading,
  Text,
  SimpleGrid,
  VStack,
  Stat,
  StatLabel,
  StatNumber,
  CircularProgress,
  CircularProgressLabel,
  useStatStyles,
} from "@chakra-ui/react";
import { useEffect, useState } from "react";
import {
  LineChart,
  Line,
  XAxis,
  YAxis,
  CartesianGrid,
  Tooltip,
  Legend,
  ResponsiveContainer,
  BarChart,
  Bar,
} from "recharts";

// Örnek veri
const upcomingEvents = [
  { title: "Kitap Kulübü Toplantısı", date: "24 Mayıs 2024" },
  { title: "Yazar Söyleşisi", date: "28 Mayıs 2024" },
  { title: "Okuma Maratonu", date: "2 Haziran 2024" },
];

const popularBooks = [
  { title: "Yabancı", author: "Albert Camus", borrowed: 42 },
  { title: "Suç ve Ceza", author: "Fyodor Dostoevsky", borrowed: 35 },
  { title: "1984", author: "George Orwell", borrowed: 30 },
  { title: "Küçük Prens", author: "Antoine de Saint-Exupéry", borrowed: 28 },
];

const stockData = [
  { name: "Romanlar", value: 450 },
  { name: "Polisiye", value: 320 },
  { name: "Bilim Kurgu", value: 280 },
  { name: "Klasikler", value: 210 },
];

const dailyStats = {
  newMembers: 15,
  newBooks: 25,
  returnedBooks: 10,
};

// Örnek veri kümesi 1
const monthlyData = [
  { month: "Ocak", newMembers: 200, newBooks: 300 },
  { month: "Şubat", newMembers: 150, newBooks: 250 },
  { month: "Mart", newMembers: 250, newBooks: 350 },
  { month: "Nisan", newMembers: 180, newBooks: 280 },
  { month: "Mayıs", newMembers: 220, newBooks: 320 },
  { month: "Haziran", newMembers: 190, newBooks: 270 },
];

// Örnek veri kümesi 2
const weeklyData = [
  { week: "Hafta 1", newMembers: 30, newBooks: 40 },
  { week: "Hafta 2", newMembers: 35, newBooks: 45 },
  { week: "Hafta 3", newMembers: 28, newBooks: 38 },
  { week: "Hafta 4", newMembers: 32, newBooks: 42 },
];

// Örnek veri kümesi 3
const yearlyData = [
  { year: 2022, newMembers: 1500, newBooks: 2000 },
  { year: 2023, newMembers: 1800, newBooks: 2300 },
  { year: 2024, newMembers: 2200, newBooks: 2700 },
];

const totalBooksData = [
  { name: "Romanlar", total: 550 },
  { name: "Polisiye", total: 380 },
  { name: "Bilim Kurgu", total: 320 },
  { name: "Klasikler", total: 230 },
  { name: "Dergiler", total: 180 },
];

// Kütüphane istatistikleri için örnek veri seti
const libraryStatsData = [
  { name: 'Romanlar', total: 550 },
  { name: 'Polisiye', total: 380 },
  { name: 'Bilim Kurgu', total: 320 },
  { name: 'Klasikler', total: 230 },
  { name: 'Dergiler', total: 180 },
];

// Kullanıcı istatistikleri için örnek veri seti
const userStatsData = [
  { name: 'Pazartesi', newUsers: 20, activeUsers: 15 },
  { name: 'Salı', newUsers: 15, activeUsers: 10 },
  { name: 'Çarşamba', newUsers: 25, activeUsers: 20 },
  { name: 'Perşembe', newUsers: 18, activeUsers: 13 },
  { name: 'Cuma', newUsers: 22, activeUsers: 18 },
  { name: 'Cumartesi', newUsers: 27, activeUsers: 22 },
  { name: 'Pazar', newUsers: 30, activeUsers: 25 },
];


const Dashboard = () => {
  const [mount, setMount] = useState(false);

  useEffect(() => {
    setMount(true);
  }, []);

  return (
    <Box p={8}>
      <Heading mb={8}>Hoş Geldiniz, Yönetici!</Heading>

      {/* Günlük Rapor */}
      <Box mb={8}>
        <Heading size="md" mb={4}>
          Günlük Rapor
        </Heading>
        <SimpleGrid columns={{ base: 1, md: 3 }} spacing={4}>
          <Stat>
            <StatLabel>Yeni Üyeler</StatLabel>
            <StatNumber>{dailyStats.newMembers}</StatNumber>
          </Stat>
          <Stat>
            <StatLabel>Yeni Kitaplar</StatLabel>
            <StatNumber>{dailyStats.newBooks}</StatNumber>
          </Stat>
          <Stat>
            <StatLabel>İade Edilen Kitaplar</StatLabel>
            <StatNumber>{dailyStats.returnedBooks}</StatNumber>
          </Stat>
        </SimpleGrid>
      </Box>

      {/* Yaklaşan Etkinlikler */}
      <Box mb={8}>
        <Heading size="md" mb={4}>
          Yaklaşan Etkinlikler
        </Heading>
        <VStack align="start" spacing={4}>
          {upcomingEvents.map((event, index) => (
            <Box key={index} borderWidth="1px" borderRadius="lg" p={4} w="100%">
              <Text fontWeight="bold">{event.title}</Text>
              <Text>{event.date}</Text>
            </Box>
          ))}
        </VStack>
      </Box>

      {/* En Popüler Kitaplar */}
      <Box mb={8}>
        <Heading size="md" mb={4}>
          En Popüler Kitaplar
        </Heading>
        <SimpleGrid columns={{ base: 1, md: 2 }} spacing={4}>
          {popularBooks.map((book, index) => (
            <Box key={index} borderWidth="1px" borderRadius="lg" p={4}>
              <Text fontWeight="bold">{book.title}</Text>
              <Text>{book.author}</Text>
              <Text>{book.borrowed} kez ödünç alındı</Text>
            </Box>
          ))}
        </SimpleGrid>
      </Box>

      {/* Stok Durumu ve Kütüphane Dolum Oranı */}
      <SimpleGrid columns={{ base: 1, md: 2 }} spacing={8} mb={8}>
        <Box>
          <Heading size="md" mb={4}>
            Stok Durumu
          </Heading>
          <VStack align="start" spacing={4}>
            {stockData.map((data, index) => (
              <Stat
                key={index}
                borderWidth="1px"
                borderRadius="lg"
                p={4}
                w="100%"
              >
                <StatLabel>{data.name}</StatLabel>
                <StatNumber>{data.value}</StatNumber>
              </Stat>
            ))}
          </VStack>
        </Box>
        <Box>
          <Heading size="md" mb={4}>
            Kütüphane Dolum Oranı
          </Heading>
          <CircularProgress value={70} size="120px">
            <CircularProgressLabel>{70}%</CircularProgressLabel>
          </CircularProgress>
        </Box>
      </SimpleGrid>

      {/* Grafik */}
      <Box>
        <Heading size="md" mb={4}>
          Günlük Üye ve Kitap İstatistikleri
        </Heading>
        <ResponsiveContainer width="100%" height={300}>
          <LineChart
            width={500}
            height={300}
            data={[
              { name: "Pazartesi", newMembers: 20, newBooks: 30 },
              { name: "Salı", newMembers: 15, newBooks: 25 },
              { name: "Çarşamba", newMembers: 25, newBooks: 35 },
              { name: "Perşembe", newMembers: 18, newBooks: 28 },
              { name: "Cuma", newMembers: 22, newBooks: 32 },
              { name: "Cumartesi", newMembers: 27, newBooks: 38 },
              { name: "Pazar", newMembers: 30, newBooks: 40 },
            ]}
            margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
          >
            <XAxis dataKey="name" />
            <YAxis />
            <CartesianGrid strokeDasharray="3 3" />
            <Tooltip />
            <Legend />
            <Line type="monotone" dataKey="newMembers" stroke="#8884d8" />
            <Line type="monotone" dataKey="newBooks" stroke="#82ca9d" />
          </LineChart>
        </ResponsiveContainer>
      </Box>

      <Flex gap={3} direction={{ base: "column", xl: "row" }}>
        <MonthlyChart />
        <WeeklyChart />
        <YearlyChart />
      </Flex>

      {mount && (
        <Flex gap={3} direction={{ base: "column", xl: "row" }}>
          <UserStatsChart />
          <LibraryStatsChart />
          <TotalBooksChart />
        </Flex>
      )}
    </Box>
  );
};

// Aylık istatistikler için grafik
const MonthlyChart = () => (
  <LineChart
    width={600}
    height={300}
    data={monthlyData}
    margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
  >
    <XAxis dataKey="month" />
    <YAxis />
    <CartesianGrid strokeDasharray="3 3" />
    <Tooltip />
    <Legend />
    <Line
      type="monotone"
      dataKey="newMembers"
      stroke="#8884d8"
      activeDot={{ r: 8 }}
    />
    <Line type="monotone" dataKey="newBooks" stroke="#82ca9d" />
  </LineChart>
);

// Haftalık istatistikler için grafik
const WeeklyChart = () => (
  <LineChart
    width={600}
    height={300}
    data={weeklyData}
    margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
  >
    <XAxis dataKey="week" />
    <YAxis />
    <CartesianGrid strokeDasharray="3 3" />
    <Tooltip />
    <Legend />
    <Line
      type="monotone"
      dataKey="newMembers"
      stroke="#8884d8"
      activeDot={{ r: 8 }}
    />
    <Line type="monotone" dataKey="newBooks" stroke="#82ca9d" />
  </LineChart>
);

// Yıllık istatistikler için grafik
const YearlyChart = () => (
  <LineChart
    width={600}
    height={300}
    data={yearlyData}
    margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
  >
    <XAxis dataKey="year" />
    <YAxis />
    <CartesianGrid strokeDasharray="3 3" />
    <Tooltip />
    <Legend />
    <Line
      type="monotone"
      dataKey="newMembers"
      stroke="#8884d8"
      activeDot={{ r: 8 }}
    />
    <Line type="monotone" dataKey="newBooks" stroke="#82ca9d" />
  </LineChart>
);
// Toplam eser istatistikleri için grafik
const TotalBooksChart = () => (
  <BarChart
    width={600}
    height={300}
    data={totalBooksData}
    margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
  >
    <CartesianGrid strokeDasharray="3 3" />
    <XAxis dataKey="name" />
    <YAxis />
    <Tooltip />
    <Legend />
    <Bar dataKey="total" fill="#8884d8" />
  </BarChart>
);

// Kütüphane istatistikleri için grafik
const LibraryStatsChart = () => (
  <BarChart
    width={600}
    height={300}
    data={libraryStatsData}
    margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
  >
    <CartesianGrid strokeDasharray="3 3" />
    <XAxis dataKey="name" />
    <YAxis />
    <Tooltip />
    <Legend />
    <Bar dataKey="total" fill="#82ca9d" />
  </BarChart>
);

// Kullanıcı İstatistikleri için grafik
const UserStatsChart = () => (
  <ResponsiveContainer width="100%" height={300}>
  <BarChart
    width={500}
    height={300}
    data={userStatsData}
    margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
  >
    <CartesianGrid strokeDasharray="3 3" />
    <XAxis dataKey="name" />
    <YAxis />
    <Tooltip />
    <Legend />
    <Bar dataKey="newUsers" fill="#8884d8" />
    <Bar dataKey="activeUsers" fill="#82ca9d" />
  </BarChart>
</ResponsiveContainer>
);

export default Dashboard;

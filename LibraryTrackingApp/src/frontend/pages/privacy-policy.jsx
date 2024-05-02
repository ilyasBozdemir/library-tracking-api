import { site } from "@/constants/site";
import { NextSeo } from "next-seo";
import React from "react";
import { Container, Heading, Text, Link } from "@chakra-ui/react";

const PrivacyPolicyPage = () => {
  return (
    <>
      <NextSeo
        title="Privacy Policy"
        description="This is the privacy policy of our website."
        canonical={`${site.API_BASE_URL}/privacy-policy`}
        openGraph={{
          type: "website",
          url: `${site.API_BASE_URL}/privacy-policy`,
          title: "Privacy Policy",
          description: "This is the privacy policy of our website.",
          site_name: "Library Automation",
        }}
      />

      <Container maxW="container.lg" mt={8}>
        <Heading as="h1" mb={4}>
          Gizlilik Politikası
        </Heading>
        <Text mb={4}>
          Bu gizlilik politikası, [şirket adı] tarafından işletilen [web sitesi
          adı] web sitesi ve [mobil uygulama adı] mobil uygulaması ('Servis')
          kullanıcılarının gizliliğini ilgilendirir. Servisimizi
          kullandığınızda, bu politikayı kabul etmiş olursunuz ve kişisel
          verilerinizi bu politikanın açıkladığı şekilde kullanmamıza izin
          vermiş olursunuz.
        </Text>
        <Heading as="h2" size="md" mt={4} mb={2}>
          Toplanan Veriler ve Kullanımı
        </Heading>
        <Text mb={4}>
          Servisi kullanırken, belirli kişisel olarak tanımlanabilir bilgileri
          toplayabiliriz, bu bilgileri toplama ve kullanma hakkında daha fazla
          bilgi için lütfen <Link href="/privacy">Gizlilik Politikamızı</Link>{" "}
          ziyaret edin.
        </Text>
        <Heading as="h2" size="md" mt={4} mb={2}>
          Çerezler
        </Heading>
        <Text mb={4}>
          Çerezler, bir web sitesini veya hizmeti kullanımınız sırasında
          tarayıcınıza yerleştirilen küçük bir veri parçasıdır. Daha fazla bilgi
          için lütfen <Link href="/cookies">Çerez Politikamızı</Link> ziyaret
          edin.
        </Text>
        <Heading as="h2" size="md" mt={4} mb={2}>
          Üçüncü Taraf Bağlantıları
        </Heading>
        <Text mb={4}>
          Servisimizde üçüncü taraf web sitelerine bağlantılar bulunabilir. Bu
          bağlantıları kullanırken dikkatli olmanızı öneririz. Herhangi bir
          üçüncü taraf web sitesinin gizlilik politikasını kontrol etmeli ve
          kabul etmelisiniz.
        </Text>
        <Heading as="h2" size="md" mt={4} mb={2}>
          Değişiklikler
        </Heading>
        <Text mb={4}>
          Gizlilik politikamızı zaman zaman güncelleyebiliriz. Bu sayfayı
          düzenli olarak ziyaret ederek güncellemeler hakkında bilgi
          edinebilirsiniz.
        </Text>
      </Container>
    </>
  );
};

export default PrivacyPolicyPage;

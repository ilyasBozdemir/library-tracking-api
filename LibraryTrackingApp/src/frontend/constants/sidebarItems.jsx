import { FiHome, FiSettings, FiLogOut } from "react-icons/fi";
import {
  BsArrowLeftRight,
  BsBook,
  BsBuilding,
  BsPeople,
  BsPeopleFill,
  BsPerson,
  BsTagFill,
} from "react-icons/bs";
import { FaBookOpen } from "react-icons/fa";

export const sidebarItems = [
    { title: "Ana Sayfa", icon: <FiHome />, href: "/admin" },
    { title: "Kütüphane", icon: <BsBuilding />, href: "/admin/library" },
    { title: "Yazarlar", icon: <BsPerson />, href: "/admin/author" },
    { title: "Kitaplar", icon: <BsBook />, href: "/admin/book" },
    { title: "Türler", icon: <FaBookOpen />, href: "/admin/genre" },
    { title: "Üyeler", icon: <BsPeople />, href: "/admin/member" },
    { title: "Personel", icon: <BsPeopleFill />, href: "/admin/staff" },
    {
      title: "Ödünç Verilen Kitaplar",
      icon: <BsArrowLeftRight />,
      href: "/admin/borrow",
    },
    { title: "Etiketler", icon: <BsTagFill />, href: "/admin/book-tag" },
    { title: "Ayarlar", icon: <FiSettings />, href: "/admin/settings" },
    { title: "Çıkış Yap", icon: <FiLogOut />, href: "/admin/logout" },
  ];

 export const items = [
    {
      title: "Kütüphane",
      description:
        "Kütüphane bilgilerini düzenleyin, yeni kütüphaneler ekleyin.",
      link: "/admin/library",
    },
    {
      title: "Üyeler",
      description: "Üyeleri yönetin, yeni üyeler ekleyin.",
      link: "/admin/member",
    },
    {
      title: "Kitaplar",
      description: "Kitapları düzenleyin, yeni kitaplar ekleyin.",
      link: "/admin/book",
    },
    {
      title: "Personel",
      description: "Personel bilgilerini yönetin, yeni personel ekleyin.",
      link: "/admin/staff",
    },
    {
      title: "Ödünç Verme",
      description: "Kitap ödünç verme işlemlerini yönetin.",
      link: "/admin/borrow",
    },
    {
      title: "Kitap Türleri",
      description: "Kitap türlerini düzenleyin, yeni türler ekleyin.",
      link: "/admin/genre",
    },
    {
      title: "Kitap Etiketleri",
      description:
        "Arama terimlerini yönetin, popüler arama terimlerini görüntüleyin ve düzenleyin.",
      link: "/admin/book-tag",
    },
  ];
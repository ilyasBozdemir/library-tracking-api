import { FiHome, FiSettings, FiLogOut, FiBook } from "react-icons/fi";
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
  {
    title: "Ana Sayfa",
    icon: <FiHome />,
    href: "/admin",
    target: "_self",
  },
  {
    title: "Kütüphane",
    icon: <BsBuilding />,
    href: "/admin/library",
    target: "_self",
  },
  {
    title: "Yazarlar",
    icon: <BsPerson />,
    href: "/admin/author",
    target: "_self",
  },
  { title: "Kitaplar", icon: <BsBook />, href: "/admin/book", target: "_self" },
  {
    title: "Türler",
    icon: <FaBookOpen />,
    href: "/admin/genre",
    target: "_self",
  },
  {
    title: "Üyeler",
    icon: <BsPeople />,
    href: "/admin/member",
    target: "_self",
  },
  {
    title: "Personel",
    icon: <BsPeopleFill />,
    href: "/admin/staff",
    target: "_self",
  },
  {
    title: "Ödünç Verilen Kitaplar",
    icon: <BsArrowLeftRight />,
    href: "/admin/borrow",
    target: "_self",
  },
  {
    title: "Etiketler",
    icon: <BsTagFill />,
    href: "/admin/book-tag",
    target: "_self",
  },
  {
    title: "Ayarlar",
    icon: <FiSettings />,
    href: "/admin/settings",
    target: "_self",
  },
  {
    title: "Geliştirici Belgeleri",
    icon: <FiBook />,
    href: "/docs",
    target: "_blank",
  },
  {
    title: "Çıkış Yap",
    icon: <FiLogOut />,
    href: "/admin/logout",
    target: "_self",
  },
];

export const items = [
  {
    title: "Kütüphane",
    description: "Kütüphane bilgilerini düzenleyin, yeni kütüphaneler ekleyin.",
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

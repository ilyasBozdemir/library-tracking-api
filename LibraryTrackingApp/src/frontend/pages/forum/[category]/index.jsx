import React from 'react';
import { useRouter } from 'next/router';

const CategoryPage = () => {
  const router = useRouter();
  const { category } = router.query;

  return (
    <div>
      <h1>{category} Kategorisi</h1>
      <p>Bu sayfa {category} kategorisiyle ilgili içeriği gösterir.</p>
    </div>
  );
};

export default CategoryPage;

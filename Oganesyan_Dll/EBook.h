#pragma once

#include "pch.h"
#include "Book.h"

class EBook : public Book
{
	friend class boost::serialization::access;

public:

	string link = "";

	string getLink() const { return link; }

	void setLink(const string& link) { this->link = link; }

	BOOST_SERIALIZATION_SPLIT_MEMBER()

		virtual ~EBook() {}

	template<class Archive>
	void save(Archive& ar, const unsigned int version) const
	{
		ar& boost::serialization::base_object<Book>(*this);
		ar& link;
	}

	template<class Archive>
	void load(Archive& ar, const unsigned int version)
	{
		ar& boost::serialization::base_object<Book>(*this);
		ar& link;
	}
};

BOOST_CLASS_VERSION(EBook, 1)
#pragma once
#include "pch.h"

class Book
{
	friend class boost::serialization::access;

public:

	string title = "";
	string author = "";
	int release_year = 0;
	string publishing_house = "";
	bool in_stock = 0;
	double rating = 0;

	template<class Archive>
	void serialize(Archive& ar, const unsigned int version)
	{
		ar& title;
		ar& author;
		ar& release_year;
		ar& publishing_house;
		ar& in_stock;
		ar& rating;
	}

	string getTitle() const { return title; }
	string getAuthor() const { return author; }
	int getRelease_Year() const { return release_year; }
	string getPublishing_House() const { return publishing_house; }
	bool getIn_Stock() const { return in_stock; }
	double getRating() const { return rating; }

	void setTitle(const string& title) { this->title = title; }
	void setAuthor(const string& author) { this->author = author; }
	void setRelease_Year(int release_year) { this->release_year = release_year; }
	void setPublishing_House(const string& publishing_house) { this->publishing_house = publishing_house; }
	void setIn_Stock(bool in_stock) { this->in_stock = in_stock; }
	void setRating(double rating) { this->rating = rating; }

	virtual ~Book() = default;
};
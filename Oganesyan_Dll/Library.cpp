#include "pch.h"
#include "Utils.h"
#include "Library.h"
#include "EBook.h"

//void Library::AddBook() {
//    auto book = std::make_shared<Book>();
//    books.push_back(book);
//}

//void Library::AddEBook() {
//    auto eBook = std::make_shared<EBook>();
//    books.push_back(eBook);
//}

void Library::AddBook(shared_ptr<Book> book) {
    books.push_back(book);
}

void Library::Clear() {
    books.clear();
}

void Library::SaveToFile(const string& filename) {
    try {
        std::ofstream fout(filename, ios::binary);
        if (!fout) {
            std::cerr << "�� ������� ������� ���� ��� ������." << std::endl;
            return;
        }
        boost::archive::text_oarchive oa(fout);
        oa << books;
        std::cout << "����� ������� ��������� � ����: " << filename << std::endl;
    }
    catch (const std::exception& e) {
        std::cerr << "������ ��� ���������� �����: " << e.what() << std::endl;
    }
}

void Library::LoadFromFile(const string& filename) {
    try {
        ifstream fin(filename, ios::binary);
        if (!fin) {
            std::cerr << "�� ������� ������� ���� ��� ��������." << std::endl;
            return;
        }
        boost::archive::text_iarchive ia(fin);
        books.clear();
        ia >> books;
        cout << "����� ������� ��������� �� �����: " << filename << endl;
    }
    catch (const std::exception& e) {
        cerr << "������ ��� �������� �����: " << e.what() << endl;
        books.clear();
    }
}

shared_ptr<Book> Library::get(int i) {
    return books[i];
}

int Library::GetSize() const {
    return books.size();
}

//void Library::start() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    locale::global(locale("Russian"));
//}

//int filmoteka::GetSize() const {
//    return static_cast<int>(movies.size());
//}
//
//shared_ptr<films> filmoteka::GetFilm(int id) const {
//    if (id < 0 || id >= GetSize()) {
//        throw out_of_range("Invalid film ID");
//    }
//    return movies[id];
//}

void Library::Delete(int id) {
    books.erase(books.begin() + id);
}

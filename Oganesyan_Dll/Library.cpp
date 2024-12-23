#include "pch.h"
#include "Utils.h"
#include "Library.h"
#include "EBook.h"

void Library::AddBook(shared_ptr<Book> book) {
    books.push_back(book);
}

void Library::Clear() {
    books.clear();
}

void Library::SaveToFile(const string& filename) {
    try {
        ofstream fout(filename, ios::binary);
        if (!fout) {
            cerr << "Не удалось открыть файл для записи." << endl;
            return;
        }
        boost::archive::text_oarchive oa(fout);
        oa << books;
        cout << "Книги успешно сохранены в файл: " << filename << endl;
    }
    catch (const exception& e) {
        cerr << "Ошибка при сохранении файла: " << e.what() << endl;
    }
}

void Library::LoadFromFile(const string& filename) {
    try {
        ifstream fin(filename, ios::binary);
        if (!fin) {
            cerr << "Не удалось открыть файл для загрузки." << endl;
            return;
        }
        boost::archive::text_iarchive ia(fin);
        books.clear();
        ia >> books;
        cout << "Книги успешно загружены из файла: " << filename << endl;
    }
    catch (const exception& e) {
        cerr << "Ошибка при загрузке файла: " << e.what() << endl;
        books.clear();
    }
}

shared_ptr<Book> Library::get(int i) {
    return books[i];
}

int Library::GetSize() const {
    return books.size();
}

void Library::Delete(int id) {
    books.erase(books.begin() + id);
}

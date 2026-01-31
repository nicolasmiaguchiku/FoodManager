using FoodManager.Catalog.Domain.Enums;

namespace FoodManager.Catalog.Domain.ValueObjects
{
    public record ImageFile
    {
        public Guid Id { get; set; }
        public DateTime ImportedAt { get; set; }
        public FileStatus FileStatus { get; set; }
        public string FilePath { get; set; } = default!;

        public ImageFile SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public ImageFile SetDateTime(DateTime date)
        {
            ImportedAt = date;
            return this;
        }

        public ImageFile SetFileStatus(FileStatus fileStatus)
        {
            FileStatus = fileStatus;
            return this;
        }

        public ImageFile SetFilePath(string filePath)
        {
            FilePath = filePath;
            return this;
        }

        public Builder ToBuilder()
        {
            return new Builder
            {
                Id = Id,
                ImportedAt = ImportedAt,
                FileStatus = FileStatus,
                FilePath = FilePath,
            };
        }

        public class Builder
        {
            public Guid Id { get; set; }
            public DateTime ImportedAt { get; set; }
            public FileStatus FileStatus { get; set; }
            public string FilePath { get; set; } = default!;

            public static Builder Create() => new();

            public Builder SetId(Guid id) { Id = id; return this; }
            public Builder SetDateTime(DateTime date) { ImportedAt = date; return this; }
            public Builder SetFileStatus(FileStatus fileStatus) { FileStatus = fileStatus; return this; }
            public Builder SetFilePath(string filePath) { FilePath = filePath; return this; }

            public ImageFile Build()
            {
                return new ImageFile
                {
                    Id = Id,
                    ImportedAt = ImportedAt,
                    FileStatus = FileStatus,
                    FilePath = FilePath,
                };
            }
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Ffs.Models
{
    public partial class ExcelContext : DbContext
    {
        public ExcelContext()
        {
        }

        public ExcelContext(DbContextOptions<ExcelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllTable> AllTables { get; set; }
        public virtual DbSet<TableSheet> TableSheets { get; set; }
        public virtual DbSet<TableXd> TableXds { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<_151> _151s { get; set; }
        public virtual DbSet<_152> _152s { get; set; }
        public virtual DbSet<_153> _153s { get; set; }
        public virtual DbSet<_154> _154s { get; set; }
        public virtual DbSet<_155> _155s { get; set; }
        public virtual DbSet<_156> _156s { get; set; }
        public virtual DbSet<_161> _161s { get; set; }
        public virtual DbSet<_1610> _1610s { get; set; }
        public virtual DbSet<_1611> _1611s { get; set; }
        public virtual DbSet<_1612> _1612s { get; set; }
        public virtual DbSet<_1613> _1613s { get; set; }
        public virtual DbSet<_1614> _1614s { get; set; }
        public virtual DbSet<_1615> _1615s { get; set; }
        public virtual DbSet<_162> _162s { get; set; }
        public virtual DbSet<_163> _163s { get; set; }
        public virtual DbSet<_164> _164s { get; set; }
        public virtual DbSet<_165> _165s { get; set; }
        public virtual DbSet<_166> _166s { get; set; }
        public virtual DbSet<_167> _167s { get; set; }
        public virtual DbSet<_168> _168s { get; set; }
        public virtual DbSet<_169> _169s { get; set; }
        public virtual DbSet<_171> _171s { get; set; }
        public virtual DbSet<_172> _172s { get; set; }
        public virtual DbSet<_181> _181s { get; set; }
        public virtual DbSet<_1810> _1810s { get; set; }
        public virtual DbSet<_1811> _1811s { get; set; }
        public virtual DbSet<_1812> _1812s { get; set; }
        public virtual DbSet<_1813> _1813s { get; set; }
        public virtual DbSet<_1814> _1814s { get; set; }
        public virtual DbSet<_1815> _1815s { get; set; }
        public virtual DbSet<_1816> _1816s { get; set; }
        public virtual DbSet<_1817> _1817s { get; set; }
        public virtual DbSet<_1818> _1818s { get; set; }
        public virtual DbSet<_1819> _1819s { get; set; }
        public virtual DbSet<_182> _182s { get; set; }
        public virtual DbSet<_1820> _1820s { get; set; }
        public virtual DbSet<_1821> _1821s { get; set; }
        public virtual DbSet<_1822> _1822s { get; set; }
        public virtual DbSet<_183> _183s { get; set; }
        public virtual DbSet<_184> _184s { get; set; }
        public virtual DbSet<_185> _185s { get; set; }
        public virtual DbSet<_186> _186s { get; set; }
        public virtual DbSet<_187> _187s { get; set; }
        public virtual DbSet<_188> _188s { get; set; }
        public virtual DbSet<_189> _189s { get; set; }
        public virtual DbSet<_191> _191s { get; set; }
        public virtual DbSet<_1910> _1910s { get; set; }
        public virtual DbSet<_1911> _1911s { get; set; }
        public virtual DbSet<_1912> _1912s { get; set; }
        public virtual DbSet<_192> _192s { get; set; }
        public virtual DbSet<_193> _193s { get; set; }
        public virtual DbSet<_194> _194s { get; set; }
        public virtual DbSet<_195> _195s { get; set; }
        public virtual DbSet<_196> _196s { get; set; }
        public virtual DbSet<_197> _197s { get; set; }
        public virtual DbSet<_198> _198s { get; set; }
        public virtual DbSet<_199> _199s { get; set; }
        public virtual DbSet<_201> _201s { get; set; }
        public virtual DbSet<_2010> _2010s { get; set; }
        public virtual DbSet<_2011> _2011s { get; set; }
        public virtual DbSet<_2012> _2012s { get; set; }
        public virtual DbSet<_2013> _2013s { get; set; }
        public virtual DbSet<_2014> _2014s { get; set; }
        public virtual DbSet<_2015> _2015s { get; set; }
        public virtual DbSet<_2016> _2016s { get; set; }
        public virtual DbSet<_2017> _2017s { get; set; }
        public virtual DbSet<_2018> _2018s { get; set; }
        public virtual DbSet<_2019> _2019s { get; set; }
        public virtual DbSet<_202> _202s { get; set; }
        public virtual DbSet<_2020> _2020s { get; set; }
        public virtual DbSet<_2021> _2021s { get; set; }
        public virtual DbSet<_2022> _2022s { get; set; }
        public virtual DbSet<_2023> _2023s { get; set; }
        public virtual DbSet<_2024> _2024s { get; set; }
        public virtual DbSet<_203> _203s { get; set; }
        public virtual DbSet<_204> _204s { get; set; }
        public virtual DbSet<_205> _205s { get; set; }
        public virtual DbSet<_206> _206s { get; set; }
        public virtual DbSet<_207> _207s { get; set; }
        public virtual DbSet<_208> _208s { get; set; }
        public virtual DbSet<_209> _209s { get; set; }
        public virtual DbSet<_211> _211s { get; set; }
        public virtual DbSet<_221> _221s { get; set; }
        public virtual DbSet<_2210> _2210s { get; set; }
        public virtual DbSet<_2211> _2211s { get; set; }
        public virtual DbSet<_2212> _2212s { get; set; }
        public virtual DbSet<_2213> _2213s { get; set; }
        public virtual DbSet<_2214> _2214s { get; set; }
        public virtual DbSet<_2215> _2215s { get; set; }
        public virtual DbSet<_2216> _2216s { get; set; }
        public virtual DbSet<_2217> _2217s { get; set; }
        public virtual DbSet<_222> _222s { get; set; }
        public virtual DbSet<_223> _223s { get; set; }
        public virtual DbSet<_224> _224s { get; set; }
        public virtual DbSet<_225> _225s { get; set; }
        public virtual DbSet<_226> _226s { get; set; }
        public virtual DbSet<_227> _227s { get; set; }
        public virtual DbSet<_228> _228s { get; set; }
        public virtual DbSet<_229> _229s { get; set; }
        public virtual DbSet<_231> _231s { get; set; }
        public virtual DbSet<_232> _232s { get; set; }
        public virtual DbSet<_233> _233s { get; set; }
        public virtual DbSet<_234> _234s { get; set; }
        public virtual DbSet<_241> _241s { get; set; }
        public virtual DbSet<_2410> _2410s { get; set; }
        public virtual DbSet<_242> _242s { get; set; }
        public virtual DbSet<_243> _243s { get; set; }
        public virtual DbSet<_244> _244s { get; set; }
        public virtual DbSet<_245> _245s { get; set; }
        public virtual DbSet<_246> _246s { get; set; }
        public virtual DbSet<_247> _247s { get; set; }
        public virtual DbSet<_248> _248s { get; set; }
        public virtual DbSet<_249> _249s { get; set; }
        public virtual DbSet<_251> _251s { get; set; }
        public virtual DbSet<_261> _261s { get; set; }
        public virtual DbSet<_271> _271s { get; set; }
        public virtual DbSet<_281> _281s { get; set; }
        public virtual DbSet<_2810> _2810s { get; set; }
        public virtual DbSet<_2811> _2811s { get; set; }
        public virtual DbSet<_2812> _2812s { get; set; }
        public virtual DbSet<_2813> _2813s { get; set; }
        public virtual DbSet<_2814> _2814s { get; set; }
        public virtual DbSet<_2815> _2815s { get; set; }
        public virtual DbSet<_2816> _2816s { get; set; }
        public virtual DbSet<_282> _282s { get; set; }
        public virtual DbSet<_283> _283s { get; set; }
        public virtual DbSet<_284> _284s { get; set; }
        public virtual DbSet<_285> _285s { get; set; }
        public virtual DbSet<_286> _286s { get; set; }
        public virtual DbSet<_287> _287s { get; set; }
        public virtual DbSet<_288> _288s { get; set; }
        public virtual DbSet<_289> _289s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//           if (!optionsBuilder.IsConfigured)
//           {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=SWDEV-SGHA-DT01\\MSSQLSERVER01;Database=Excel;Trusted_Connection=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AllTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("All_tables");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.KeyId)
                    .HasMaxLength(255)
                    .HasColumnName("Key_id");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<TableSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table Sheet");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");
            });

            modelBuilder.Entity<TableXd>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PK_Table_final");

                entity.ToTable("Table_xd");

                entity.Property(e => e.KeyId)
                    .HasMaxLength(10)
                    .HasColumnName("Key_id")
                    .IsFixedLength(true);

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance_criteria");

                entity.Property(e => e.RowId)
                    .HasMaxLength(100)
                    .HasColumnName("Row_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TableId)
                    .HasMaxLength(100)
                    .HasColumnName("Table_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TestInput).HasColumnName("Test_input");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.Test1)
                    .HasMaxLength(10)
                    .HasColumnName("test")
                    .IsFixedLength(true);

                entity.Property(e => e.Yea)
                    .HasMaxLength(10)
                    .HasColumnName("yea")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<_151>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("15.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.InstallationDemand)
                    .HasMaxLength(255)
                    .HasColumnName("Installation Demand");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");
            });

            modelBuilder.Entity<_152>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("15.2");

                entity.Property(e => e.AcceptanceCriteriaVerifyAllFilesArePresent)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria - Verify all files are present#");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");
            });

            modelBuilder.Entity<_153>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("15.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(999)
                    .HasColumnName("Acceptance Criteria")
                    .IsFixedLength(true);

                entity.Property(e => e.RowId)
                    .HasMaxLength(10)
                    .HasColumnName("Row_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TableId)
                    .HasMaxLength(10)
                    .HasColumnName("Table_id")
                    .IsFixedLength(true);

                entity.Property(e => e.TestInput)
                    .HasMaxLength(999)
                    .HasColumnName("Test input")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<_154>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("15.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_155>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("15.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_156>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("15.6");

                entity.Property(e => e.Files).HasMaxLength(255);

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.Subfolder).HasMaxLength(255);

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");
            });

            modelBuilder.Entity<_161>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1610>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.10");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1611>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.11");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1612>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.12");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1613>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.13");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1614>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.14");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1615>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.15");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_162>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.F5).HasMaxLength(255);

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_163>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_164>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_165>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_166>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.6");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_167>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.7");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_168>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.8");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_169>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("16.9");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_171>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("17.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_172>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("17.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_181>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1810>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.10");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1811>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.11");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1812>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.12");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1813>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.13");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1814>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.14");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1815>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.15");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1816>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.16");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1817>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.17");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1818>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.18");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1819>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.19");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_182>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1820>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.20");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1821>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.21");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1822>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.22");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_183>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_184>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_185>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_186>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.6");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_187>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.7");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_188>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.8");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_189>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("18.9");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_191>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1910>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.10");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1911>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.11");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_1912>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.12");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_192>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_193>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_194>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.4");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_195>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_196>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.6");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_197>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.7");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_198>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.8");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_199>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("19.9");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_201>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2010>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.10");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2011>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.11");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2012>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.12");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2013>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.13");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2014>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.14");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.15");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2016>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.16");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2017>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.17");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.18");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.19");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_202>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.20");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.21");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.22");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.23");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.24");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_203>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_204>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_205>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_206>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.6");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_207>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.7");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_208>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.8");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_209>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20.9");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_211>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("21.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_221>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2210>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.10");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2211>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.11");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2212>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.12");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2213>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.13");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2214>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.14");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2215>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.15");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2216>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.16");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2217>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.17");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_222>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_224>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_225>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_226>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.6");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_227>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.7");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_228>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.8");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_229>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("22.9");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_231>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("23.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_232>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("23.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_233>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("23.3");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_234>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("23.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_241>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2410>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.10");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_242>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_243>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_244>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_245>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_246>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.6");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_247>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.7");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_248>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.8");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_249>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("24.9");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_251>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("25.1");

                entity.Property(e => e.AccpetanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Accpetance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_261>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("26.1");

                entity.Property(e => e.AccpetanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Accpetance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_271>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("27.1");

                entity.Property(e => e.AccpetanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Accpetance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput)
                    .HasMaxLength(255)
                    .HasColumnName("Test Input");
            });

            modelBuilder.Entity<_281>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.1");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2810>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.10");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2811>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.11");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2812>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.12");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2813>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.13");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2814>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.14");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2815>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.15");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_2816>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.16");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_282>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.2");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_283>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.3");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_284>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.4");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_285>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.5");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_286>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.6");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_287>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.7");

                entity.Property(e => e.AcceptanceCriteria).HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_288>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.8");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            modelBuilder.Entity<_289>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("28.9");

                entity.Property(e => e.AcceptanceCriteria)
                    .HasMaxLength(255)
                    .HasColumnName("Acceptance Criteria");

                entity.Property(e => e.RowId).HasColumnName("Row_id");

                entity.Property(e => e.TableId)
                    .HasMaxLength(255)
                    .HasColumnName("Table_id");

                entity.Property(e => e.TestInput).HasColumnName("Test Input");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WhereIsMyStuff.Models
{
    public class Entry
    {

        [Key]
        public int Entry_Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Borrowed")]
        public DateTime DateBorrowed { get; set; } = DateTime.Now;
        [Required]
        [StringLength(100, ErrorMessage = "First Name may not be longer than 100 characters.")]
        public string Item { get; set; }
        [Display(Name = "Item Type")]
        public String ItemType { get; set; }
        [Display(Name = "Item Condition")]
        public string ItemCondition { get; set; }
        public string Notes { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name may not be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Course_Academic_Unit_DataType : INotifyPropertyChanged
	{
		private Academic_Curricular_DivisionObjectType academic_Unit_ReferenceField;

		private bool course_Inventory_OwnerField;

		private bool course_Inventory_OwnerFieldSpecified;

		private bool allowed_to_OfferField;

		private bool allowed_to_OfferFieldSpecified;

		private decimal default_Offering_PercentField;

		private bool default_Offering_PercentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Curricular_DivisionObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Course_Inventory_Owner
		{
			get
			{
				return this.course_Inventory_OwnerField;
			}
			set
			{
				this.course_Inventory_OwnerField = value;
				this.RaisePropertyChanged("Course_Inventory_Owner");
			}
		}

		[XmlIgnore]
		public bool Course_Inventory_OwnerSpecified
		{
			get
			{
				return this.course_Inventory_OwnerFieldSpecified;
			}
			set
			{
				this.course_Inventory_OwnerFieldSpecified = value;
				this.RaisePropertyChanged("Course_Inventory_OwnerSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Allowed_to_Offer
		{
			get
			{
				return this.allowed_to_OfferField;
			}
			set
			{
				this.allowed_to_OfferField = value;
				this.RaisePropertyChanged("Allowed_to_Offer");
			}
		}

		[XmlIgnore]
		public bool Allowed_to_OfferSpecified
		{
			get
			{
				return this.allowed_to_OfferFieldSpecified;
			}
			set
			{
				this.allowed_to_OfferFieldSpecified = value;
				this.RaisePropertyChanged("Allowed_to_OfferSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Default_Offering_Percent
		{
			get
			{
				return this.default_Offering_PercentField;
			}
			set
			{
				this.default_Offering_PercentField = value;
				this.RaisePropertyChanged("Default_Offering_Percent");
			}
		}

		[XmlIgnore]
		public bool Default_Offering_PercentSpecified
		{
			get
			{
				return this.default_Offering_PercentFieldSpecified;
			}
			set
			{
				this.default_Offering_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Default_Offering_PercentSpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

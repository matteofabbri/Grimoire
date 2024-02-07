using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Reclassify_Asset_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private Item_DescriptorObjectType proposed_Item_ReferenceField;

		private Spend_CategoryObjectType proposed_Spend_Category_ReferenceField;

		private Asset_ClassObjectType proposed_Asset_Class_ReferenceField;

		private Asset_TypeObjectType proposed_Asset_Type_ReferenceField;

		private Asset_Useful_Life_for_Reclassify_DataType[] proposed_Useful_Life_Per_BookField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlElement(Order = 1)]
		public Item_DescriptorObjectType Proposed_Item_Reference
		{
			get
			{
				return this.proposed_Item_ReferenceField;
			}
			set
			{
				this.proposed_Item_ReferenceField = value;
				this.RaisePropertyChanged("Proposed_Item_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Spend_CategoryObjectType Proposed_Spend_Category_Reference
		{
			get
			{
				return this.proposed_Spend_Category_ReferenceField;
			}
			set
			{
				this.proposed_Spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Proposed_Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Asset_ClassObjectType Proposed_Asset_Class_Reference
		{
			get
			{
				return this.proposed_Asset_Class_ReferenceField;
			}
			set
			{
				this.proposed_Asset_Class_ReferenceField = value;
				this.RaisePropertyChanged("Proposed_Asset_Class_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Asset_TypeObjectType Proposed_Asset_Type_Reference
		{
			get
			{
				return this.proposed_Asset_Type_ReferenceField;
			}
			set
			{
				this.proposed_Asset_Type_ReferenceField = value;
				this.RaisePropertyChanged("Proposed_Asset_Type_Reference");
			}
		}

		[XmlElement("Proposed_Useful_Life_Per_Book", Order = 5)]
		public Asset_Useful_Life_for_Reclassify_DataType[] Proposed_Useful_Life_Per_Book
		{
			get
			{
				return this.proposed_Useful_Life_Per_BookField;
			}
			set
			{
				this.proposed_Useful_Life_Per_BookField = value;
				this.RaisePropertyChanged("Proposed_Useful_Life_Per_Book");
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

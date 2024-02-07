using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Guest_Header__HV__RequestType : INotifyPropertyChanged
	{
		private Guest_Listing_FileObjectType guest_Listing_File_ReferenceField;

		private Guest_Listing_File__HV__DataType guest_Listing_File_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Guest_Listing_FileObjectType Guest_Listing_File_Reference
		{
			get
			{
				return this.guest_Listing_File_ReferenceField;
			}
			set
			{
				this.guest_Listing_File_ReferenceField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Guest_Listing_File__HV__DataType Guest_Listing_File_Data
		{
			get
			{
				return this.guest_Listing_File_DataField;
			}
			set
			{
				this.guest_Listing_File_DataField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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

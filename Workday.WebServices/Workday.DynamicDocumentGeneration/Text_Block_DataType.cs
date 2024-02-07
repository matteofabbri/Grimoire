using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Text_Block_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string last_Updated_ByField;

		private string text_Block_NameField;

		private Template_TypeObjectType source_ReferenceField;

		private Text_Block_CategoryObjectType text_Block_Category_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool do_Not_Allow_EditingField;

		private bool do_Not_Allow_EditingFieldSpecified;

		private string text_Block_ContentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Last_Updated_By
		{
			get
			{
				return this.last_Updated_ByField;
			}
			set
			{
				this.last_Updated_ByField = value;
				this.RaisePropertyChanged("Last_Updated_By");
			}
		}

		[XmlElement(Order = 2)]
		public string Text_Block_Name
		{
			get
			{
				return this.text_Block_NameField;
			}
			set
			{
				this.text_Block_NameField = value;
				this.RaisePropertyChanged("Text_Block_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Template_TypeObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Text_Block_CategoryObjectType Text_Block_Category_Reference
		{
			get
			{
				return this.text_Block_Category_ReferenceField;
			}
			set
			{
				this.text_Block_Category_ReferenceField = value;
				this.RaisePropertyChanged("Text_Block_Category_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Do_Not_Allow_Editing
		{
			get
			{
				return this.do_Not_Allow_EditingField;
			}
			set
			{
				this.do_Not_Allow_EditingField = value;
				this.RaisePropertyChanged("Do_Not_Allow_Editing");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Allow_EditingSpecified
		{
			get
			{
				return this.do_Not_Allow_EditingFieldSpecified;
			}
			set
			{
				this.do_Not_Allow_EditingFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Allow_EditingSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Text_Block_Content
		{
			get
			{
				return this.text_Block_ContentField;
			}
			set
			{
				this.text_Block_ContentField = value;
				this.RaisePropertyChanged("Text_Block_Content");
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

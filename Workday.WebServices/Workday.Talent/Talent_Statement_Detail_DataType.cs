using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Talent_Statement_Detail_DataType : INotifyPropertyChanged
	{
		private string talent_Statement_Reference_IDField;

		private RoleObjectType role_ReferenceField;

		private Talent_Statement_TypeObjectType talent_Statement_Type_ReferenceField;

		private string talent_StatementField;

		private RoleObjectType author_ReferenceField;

		private bool removeField;

		private bool removeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Talent_Statement_Reference_ID
		{
			get
			{
				return this.talent_Statement_Reference_IDField;
			}
			set
			{
				this.talent_Statement_Reference_IDField = value;
				this.RaisePropertyChanged("Talent_Statement_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public RoleObjectType Role_Reference
		{
			get
			{
				return this.role_ReferenceField;
			}
			set
			{
				this.role_ReferenceField = value;
				this.RaisePropertyChanged("Role_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Talent_Statement_TypeObjectType Talent_Statement_Type_Reference
		{
			get
			{
				return this.talent_Statement_Type_ReferenceField;
			}
			set
			{
				this.talent_Statement_Type_ReferenceField = value;
				this.RaisePropertyChanged("Talent_Statement_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Talent_Statement
		{
			get
			{
				return this.talent_StatementField;
			}
			set
			{
				this.talent_StatementField = value;
				this.RaisePropertyChanged("Talent_Statement");
			}
		}

		[XmlElement(Order = 4)]
		public RoleObjectType Author_Reference
		{
			get
			{
				return this.author_ReferenceField;
			}
			set
			{
				this.author_ReferenceField = value;
				this.RaisePropertyChanged("Author_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Remove
		{
			get
			{
				return this.removeField;
			}
			set
			{
				this.removeField = value;
				this.RaisePropertyChanged("Remove");
			}
		}

		[XmlIgnore]
		public bool RemoveSpecified
		{
			get
			{
				return this.removeFieldSpecified;
			}
			set
			{
				this.removeFieldSpecified = value;
				this.RaisePropertyChanged("RemoveSpecified");
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
